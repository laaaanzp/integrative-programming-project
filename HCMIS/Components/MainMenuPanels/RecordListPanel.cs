using HCMIS.Database;
using HCMIS.Interface;
using HCMIS.Models;
using System.Data;
using System.Diagnostics;
using System.Windows;
using System.Windows.Forms;

namespace HCMIS.Components
{
    public partial class RecordListPanel : UserControl, IKeyPressListener
    {
        private Dictionary<int, Record> _records = new Dictionary<int, Record>();

        public RecordListPanel()
        {
            InitializeComponent();

            foreach (DataGridViewColumn column in tableGrid.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Font = new Font("Poppins SemiBold", 10, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            }
        }

        private void loadData()
        {
            tableGrid.Rows.Clear();
            _records.Clear();

            List<Record> records = DatabaseHandler.DB.GetRecords();

            records.ForEach(record =>
            {
                _records.Add(record.ID, record);
                tableGrid.Rows.Add(
                    record.ID,
                    record.Patient.ID,
                    record.Patient.Fullname,
                    record.VisitDateTime.ToString("MMMM dd, yyyy"),
                    record.VisitDateTime.ToString("hh:mm tt"),
                    record.AssignedWorker,
                    record.Reason
                    );
            });
        }
        

        private void removeRow()
        {
            if (tableGrid.SelectedRows.Count == 0)
                return;

            DataGridViewRow row = tableGrid.SelectedRows[0];
            int id = (int)row.Cells[0].Value;

            if (MessageBox.Show(
                $"Deleting selected row with ID of {id}. Continue?",
                "Continue?",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
                ) != DialogResult.OK) return;

            DatabaseHandler.DB.RemoveRecord(id);
            loadData();
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

        private void onFilterTextboxValueChanged(object sender, EventArgs e)
        {
            for (int u = 0; u < tableGrid.RowCount; u++)
            {
                string fullname =       (string)tableGrid.Rows[u].Cells[2].Value;
                string assignedWorker = (string)tableGrid.Rows[u].Cells[5].Value;
                string reason =         (string)tableGrid.Rows[u].Cells[6].Value;

                tableGrid.Rows[u].Visible =
                    fullname.Contains(
                        $"{filterFullnameTextbox.Value}",
                        StringComparison.OrdinalIgnoreCase)
                    &&
                    assignedWorker.Contains(
                        $"{filterAssignedWorkerTextbox.Value}",
                        StringComparison.OrdinalIgnoreCase);
            }
        }
        private void updateLabels()
        {
            if (tableGrid.SelectedRows.Count > 0)
            {
                int id = (int)tableGrid.SelectedRows[0].Cells[0].Value;

                Record record = _records[id];
                genderLabel.Text = $"Gender: {record.Patient.Gender}";
                emailLabel.Text = $"Email: {record.Patient.Contact.Email}";
                phoneNumberLabel.Text = $"Phone Number: {record.Patient.Contact.PhoneNumber}";
                addressLabel.Text = $"Address: {record.Patient.Address}";
                birthdateLabel.Text = $"Birthday: {record.Patient.Birthday.ToString("MMMM dd, yyyy")}";
                bloodTypeLabel.Text = $"Blood Type: {record.Patient.Bloodtype}";
                maritalStatusLabel.Text = $"Marital Status: {record.Patient.MaritalStatus}";
                bloodTypeLabel.Text = $"Blood Pressure: {record.BloodPressure}";
                weightLabel.Text = $"Weight (kg): {record.WeightKG}";
                heightLabel.Text = $"Height (ft): {record.HeightFT}";
                bmiLabel.Text = $"BMI: {Tools.CalculateBMI(record.WeightKG, record.HeightFT).ToString("N1")}";
                reasonLabel.Text = $"Reason: {record.Reason}";
                remarksLabel.Text = $"Remarks: {record.Remarks}";

                if (record.Deferred)
                    deferredLabel.Text = "Deferred: Yes";
                else
                    deferredLabel.Text = "Deferred: No";
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
                remarksLabel.Text = "Remarks:";
                deferredLabel.Text = "Deferred:";
            }
        }
        private void tableGrid_SelectionChanged(object sender, EventArgs e)
        {
            updateLabels();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            Tools.SaveDataGridToFileAsPDF(tableGrid, "Record List");
        }

        private void viewProfileButton_Click(object sender, EventArgs e)
        {
            if (tableGrid.SelectedRows.Count == 0) return;

            DataGridViewRow row = tableGrid.SelectedRows[0];
            int id = (int)row.Cells[1].Value;

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
