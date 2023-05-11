using HCMIS.Database;
using HCMIS.Interface;
using HCMIS.Models;
using System.Windows;
using System.Windows.Forms;

namespace HCMIS.Components
{
    public partial class QueueListPanel : UserControl, IKeyPressListener
    {
        private Dictionary<int, Queue> _queues = new Dictionary<int, Queue>();
        public QueueListPanel()
        {
            InitializeComponent();
            JobPosition position = Globals.LoggedInEmployee.Position;

            addButton.Visible = position == JobPosition.Admin ||
                            position == JobPosition.Nurse;

            approveButton.Visible = position == JobPosition.Admin ||
                            position == JobPosition.Doctor;

            foreach (DataGridViewColumn column in tableGrid.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Font = new Font("Poppins SemiBold", 10, FontStyle.Bold, GraphicsUnit.Point);
            }

            tableGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            tableGrid.AllowUserToResizeRows = false;
            tableGrid.RowTemplate.Height = 40;

            loadData();
        }

        public void OnKeyPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    loadData();
                    break;
                case Keys.Delete:
                    removeRow();
                    break;
            }
        }

        private void loadData()
        {
            tableGrid.Rows.Clear();
            _queues.Clear();
            List<Queue> queues = DatabaseHandler.DB.GetQueues();

            queues.ForEach(queue =>
            {
                _queues.Add(queue.ID, queue);
                tableGrid.Rows.Add(queue.ID, queue.Patient.Fullname);
            });
        }

        private void removeRow()
        {
            if (tableGrid.SelectedRows.Count == 0 || !removeButton.Visible)
                return;

            DataGridViewRow row = tableGrid.SelectedRows[0];
            int id = (int)row.Cells[0].Value;

            if (MessageBox.Show(
                $"Deleting selected row with ID of {id}. Continue?",
                "Continue?",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
                ) != DialogResult.OK) return;

            DatabaseHandler.DB.RemoveQueue(id);
            tableGrid.Rows.Remove(row);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            removeRow();
        }

        private void reloadDataButton_Click(object sender, EventArgs e)
        {
            loadData();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            loadData();     
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (AddQueueForm form = new AddQueueForm())
            {                
                Globals.MainMenuFormRef.Opacity = 0.90;
                form.ShowDialog();
            }
            Globals.MainMenuFormRef.Opacity = 1;

            loadData();
        }

        private void updateLabels()
        {
            if (tableGrid.SelectedRows.Count > 0)
            {
                int id = (int)tableGrid.SelectedRows[0].Cells[0].Value;

                Queue queue = _queues[id];
                genderLabel.Text = $"Gender: {queue.Patient.Gender}";
                emailLabel.Text = $"Email: {queue.Patient.Contact.Email}";
                phoneNumberLabel.Text = $"Phone Number: {queue.Patient.Contact.PhoneNumber}";
                addressLabel.Text = $"Address: {queue.Patient.Address}";
                birthdateLabel.Text = $"Birthday: {queue.Patient.Birthday.ToString("MMMM dd, yyyy")}";
                bloodTypeLabel.Text = $"Blood Type: {queue.Patient.Bloodtype}";
                maritalStatusLabel.Text = $"Marital Status: {queue.Patient.MaritalStatus}";
                bloodTypeLabel.Text = $"Blood Pressure: {queue.BloodPressure}";
                weightLabel.Text = $"Weight (kg): {queue.WeightKG}";
                heightLabel.Text = $"Height (ft): {queue.HeightFT}";
                bmiLabel.Text = $"BMI: {Tools.CalculateBMI(queue.WeightKG, queue.HeightFT).ToString("N1")}";
                reasonLabel.Text = $"Reason: {queue.Reason}";
            }
            else
            {
                genderLabel.Text = "Gender:";
                emailLabel.Text = "Email:";
                phoneNumberLabel.Text = "Phone Number";
                addressLabel.Text = "Address:";
                birthdateLabel.Text = "Birthday:";
                bloodTypeLabel.Text = "Blood Type:";
                maritalStatusLabel.Text = "Marital Status:";
                bloodTypeLabel.Text = "Blood Pressure:";
                weightLabel.Text = "Weight (kg):";
                heightLabel.Text = "Height (ft):";
                bmiLabel.Text = "BMI:";
                reasonLabel.Text = "Reason:";
            }
        }

        private void tableGrid_SelectionChanged(object sender, EventArgs e)
        {
            removeButton.Enabled = tableGrid.SelectedRows.Count > 0;
            approveButton.Enabled = tableGrid.SelectedRows.Count > 0;
            updateLabels();
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void approveButton_Click(object sender, EventArgs e)
        {
            if (tableGrid.SelectedRows.Count == 0) return;

            DataGridViewRow row = tableGrid.SelectedRows[0];
            int id = (int)row.Cells[0].Value;

            Queue queue = _queues[id];
            string remarks;
            bool deferred;

            using (ApproveQueueForm form = new ApproveQueueForm(queue))
            {
                if (form.ShowDialog() != DialogResult.OK)
                    return;

                remarks = form.Remarks;
                deferred = form.Deferred;
            }

            Patient patient = DatabaseHandler.DB.GetPatient(queue.Patient.ID);
            Record record = new Record(
                0,
                patient,
                DateTime.Now,
                queue.BloodPressure,
                queue.WeightKG,
                queue.HeightFT,
                Globals.LoggedInEmployee.Name.FullName,
                queue.Reason,
                remarks,
                deferred
                );

            DatabaseHandler.DB.AddRecord(id, record);
            DatabaseHandler.DB.RemoveQueue(id);
            tableGrid.Rows.Remove(row);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void viewProfileButton_Click(object sender, EventArgs e)
        {
            if (tableGrid.SelectedRows.Count == 0) return;

            DataGridViewRow row = tableGrid.SelectedRows[0];
            int id = (int)row.Cells[0].Value;

            Patient patient = DatabaseHandler.DB.GetPatient(id);
            using (PatientProfileForm form = new PatientProfileForm(patient))
            {
                Globals.MainMenuFormRef.Opacity = .95;
                form.ShowDialog();
            }
            Globals.MainMenuFormRef.Opacity = 1;
        }
    }
}
