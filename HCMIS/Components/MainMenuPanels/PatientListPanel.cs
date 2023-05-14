using HCMIS.Database;
using HCMIS.Interface;
using HCMIS.Models;
using System.Windows;
using System.Windows.Forms;

namespace HCMIS.Components
{
    public partial class PatientListPanel : UserControl, IKeyPressListener
    {
        private Dictionary<int, Patient> _patients = new Dictionary<int, Patient>();

        public PatientListPanel()
        {
            InitializeComponent();

            foreach (DataGridViewColumn column in tableGrid.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Font = new Font("Poppins SemiBold", 10, FontStyle.Bold, GraphicsUnit.Point);
            }

            addButton.Visible = editButton.Visible = removeButton.Visible =
                Globals.LoggedInEmployee.Position == JobPosition.Admin ||
                Globals.LoggedInEmployee.Position == JobPosition.Barangay_Health_Worker;


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
            _patients.Clear();

            List<Patient> patients = DatabaseHandler.DB.GetPatients();
            patients.ForEach(a =>
            {
                _patients.Add(a.ID, a);
                tableGrid.Rows.Add(
                    a.ID,
                    a.Fullname,
                    a.TotalVisit
                    );
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
                ) != DialogResult.OK)
            {
                return;
            }

            DatabaseHandler.DB.RemovePatient(id);
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
            using (RegisterPatient form = new RegisterPatient())
            {
                Globals.MainMenuFormRef.Opacity = .95;

                if (form.ShowDialog() == DialogResult.OK)
                    loadData();
            }

            Globals.MainMenuFormRef.Opacity = 1;
        }

        private void tableGrid_SelectionChanged(object sender, EventArgs e)
        {
            editButton.Enabled = tableGrid.SelectedRows.Count > 0;
            removeButton.Enabled = tableGrid.SelectedRows.Count > 0;
            updateLabels();
        }

        private void updateLabels()
        {
            if (tableGrid.SelectedRows.Count == 0)
            {
                genderLabel.Text = "Gender: ";
                emailLabel.Text = "Email: ";
                phoneNumberLabel.Text = "Phone Number: ";
                addressLabel.Text = "Address: ";
                birthdayLabel.Text = "Birthday: ";
                bloodTypeLabel.Text = "Blood Type: ";
                maritalStatusLabel.Text = "Marital Status: ";
            }
            else
            {
                int id = (int)tableGrid.SelectedRows[0].Cells[0].Value;

                genderLabel.Text = $"Gender: {_patients[id].Gender}";
                emailLabel.Text = $"Email: {_patients[id].Contact.Email} ";
                phoneNumberLabel.Text = $"Phone Number: {_patients[id].Contact.PhoneNumber}";
                addressLabel.Text = $"Address: {_patients[id].Address}";
                birthdayLabel.Text = $"Birthday: {_patients[id].Birthday.ToString("MMMM dd, yyyy")}";
                bloodTypeLabel.Text = $"Blood Type: {_patients[id].Bloodtype}";
                maritalStatusLabel.Text = $"Marital Status: {_patients[id].MaritalStatus}";
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            Tools.SaveDataGridToFileAsPDF(tableGrid, "Patient List");
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
