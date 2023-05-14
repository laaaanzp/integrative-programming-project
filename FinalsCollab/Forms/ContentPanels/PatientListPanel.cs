using FinalsCollab.Forms.DialogForms;
using FinalsCollab.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalsCollab.Forms.ContentPanels
{
    public partial class PatientListPanel : UserControl
    {
        public PatientListPanel()
        {
            InitializeComponent();
            Database.SocketConnection.OnPatientListAdd += onAdd;
            Database.SocketConnection.OnPatientListUpdate += onUpdate;
            Database.SocketConnection.OnPatientListRemove += onRemove;

            loadData();

            editButton.Enabled = deleteButton.Enabled = addButton.Enabled =
                Globals.AppState.LoggedInEmployee.Position == "admin" ||
                Globals.AppState.LoggedInEmployee.Position == "bhw";
        }

        private void loadData()
        {
            dataGridView1.Rows.Clear();
            List<PatientInformation> employees = PatientInformation.GetPatients();

            employees.ForEach(addPatientToTable);
        }

        private void onAdd(JObject value)
        {
            addPatientToTable(PatientInformation.FromJObject(value));
        }

        public void onRemove(JObject value)
        {
            removeEmployeeFromTableByID(value["id"].ToObject<int>());
        }

        private void onUpdate(JObject value)
        {
            updatePatientFromTable(PatientInformation.FromJObject(value));
        }

        private void addPatientToTable(PatientInformation patient)
        {
            removeEmployeeFromTableByID(patient.ID);

            dataGridView1.Rows.Add(
                patient.ID,
                patient.Fullname,
                patient.Gender,
                patient.Address,
                patient.Birthday.ToString("MMMM d, yyyy"),
                patient.BloodType,
                patient.MaritalStatus,
                patient.NumberOfKids,
                patient.Contact.Email,
                patient.Contact.Phone
                );
        }

        private void removeEmployeeFromTableByID(int id)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
                if (id == (int)row.Cells[0].Value)
                    dataGridView1.Rows.Remove(row);
        }

        private void updatePatientFromTable(PatientInformation patient)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (patient.ID == (int)row.Cells["_id"].Value)
                {
                    DataGridViewRow updatedRow = (DataGridViewRow)row.Clone();
                    updatedRow.Cells[0].Value = patient.ID;
                    updatedRow.Cells[1].Value = patient.Fullname;
                    updatedRow.Cells[2].Value = patient.Gender;
                    updatedRow.Cells[3].Value = patient.Address;
                    updatedRow.Cells[4].Value = patient.Birthday.ToString("MMMM d, yyyy");
                    updatedRow.Cells[5].Value = patient.BloodType;
                    updatedRow.Cells[6].Value = patient.MaritalStatus;
                    updatedRow.Cells[7].Value = patient.NumberOfKids;
                    updatedRow.Cells[8].Value = patient.Contact.Email;
                    updatedRow.Cells[9].Value = patient.Contact.Phone;
                    int index = dataGridView1.Rows.IndexOf(row);
                    dataGridView1.Rows.RemoveAt(index);
                    dataGridView1.Rows.Insert(index, updatedRow);
                }
            }
        }

        private void valueTextbox_TextChanged(object sender, EventArgs e)
        {
            updateTableFilter();
        }

        private void updateTableFilter()
        {
            string columnName = "_" + fieldComboBox.Value.Replace(' ', '_');

            for (int u = 0; u < dataGridView1.RowCount; u++)
            {
                string value = dataGridView1.Rows[u].Cells[columnName].Value.ToString();
                dataGridView1.Rows[u].Visible = value.Contains(valueTextbox.Text, StringComparison.OrdinalIgnoreCase);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            updateLabels();
        }

        private void updateLabels()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                _updateLabels("", "", "", "", "", "", "", "", "");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int id = (int)row.Cells["_id"].Value;

            _updateLabels(
                row.Cells["_gender"].Value.ToString(),
                row.Cells["_address"].Value.ToString(),
                row.Cells["_birthday"].Value.ToString(),
                row.Cells["_marital_status"].Value.ToString(),
                row.Cells["_number_of_kids"].Value.ToString(),
                row.Cells["_bloodtype"].Value.ToString(),
                PatientInformation.FromDatabase(id).TotalVisit.ToString(),
                row.Cells["_email"].Value.ToString(),
                row.Cells["_phone"].Value.ToString()
            );
        }

        private void _updateLabels(string gender, string address, string birthday, string maritalStatus, string numberOfKids, string bloodtype, string totalVisit, string email, string phone)
        {
            genderLabel.Text = "Gender: " + gender;
            addressLabel.Text = "Address: " + address;
            birthdayLabel.Text = "Birthday: " + birthday;
            maritalStatusLabel.Text = "Marital Status: " + Globals.FuncTools.ToTitleCase(maritalStatus);
            numberOfKidsLabel.Text = "Number of kids: " + numberOfKids;
            bloodtypeLabel.Text = "Bloodtype: " + bloodtype;
            totalVisitLabel.Text = "Total Visit: " + totalVisit;
            emailLabel.Text = "Email: " + email;
            phoneLabel.Text = "Phone: " + phone;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int id = (int)row.Cells["_id"].Value;

            PatientInformation patient = PatientInformation.FromDatabase(id);
            patient.DeleteFromDatabase();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int id = (int)row.Cells["_id"].Value;

            PatientInformation patient = PatientInformation.FromDatabase(id);
            Globals.AppState.MenuFormInstance.ShowFormDialog(new PatientForm(patient));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Globals.AppState.MenuFormInstance.ShowFormDialog(new PatientForm());
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            updateLabels();
        }
    }
}
