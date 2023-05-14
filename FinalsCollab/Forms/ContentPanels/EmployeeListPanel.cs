using FinalsCollab.Forms.DialogForms;
using FinalsCollab.Models;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalsCollab.Forms.ContentPanels
{
    public partial class EmployeeListPanel : UserControl
    {
        public EmployeeListPanel()
        {
            InitializeComponent();

            Database.SocketConnection.OnEmployeeListAdd += onAdd;
            Database.SocketConnection.OnEmployeeListUpdate += onUpdate;
            Database.SocketConnection.OnEmployeeListRemove += onRemove;

            loadData();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Globals.AppState.MenuFormInstance.ShowFormDialog(new ProfileForm());
        }

        private void loadData()
        {
            dataGridView1.Rows.Clear();
            List<EmployeeInformation> employees = EmployeeInformation.GetAllEmployees();

            employees.ForEach(addEmployeeToTable);
        }

        private void onAdd(JObject value)
        {
            addEmployeeToTable(EmployeeInformation.FromJObject(value));
        }

        public void onRemove(JObject value)
        {
            removeEmployeeFromTableByID(value["id"].ToObject<int>());
        }

        private void onUpdate(JObject value)
        {
            updateEmployeeFromTable(EmployeeInformation.FromJObject(value));
        }

        private void addEmployeeToTable(EmployeeInformation employee)
        {
            removeEmployeeFromTableByID(employee.ID);

            dataGridView1.Rows.Add(
                employee.ID,
                employee.Name.Firstname,
                employee.Name.Middlename,
                employee.Name.Lastname,
                employee.Position != "bhw" ? Globals.FuncTools.ToTitleCase(employee.Position) : "BHW",
                employee.Contact.Email,
                employee.Contact.Phone
                );
        }

        private void removeEmployeeFromTableByID(int id)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
                if (id == (int)row.Cells[0].Value)
                    dataGridView1.Rows.Remove(row);
        }

        private void updateEmployeeFromTable(EmployeeInformation employee)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
                if (employee.ID == (int)row.Cells[0].Value)
                {
                    DataGridViewRow updatedRow = (DataGridViewRow)row.Clone();
                    updatedRow.Cells[0].Value = employee.ID;
                    updatedRow.Cells[1].Value = employee.Name.Firstname;
                    updatedRow.Cells[2].Value = employee.Name.Middlename;
                    updatedRow.Cells[3].Value = employee.Name.Lastname;
                    updatedRow.Cells[4].Value = employee.Position != "bhw" ? Globals.FuncTools.ToTitleCase(employee.Position) : "BHW";
                    updatedRow.Cells[5].Value = employee.Contact.Email;
                    updatedRow.Cells[6].Value = employee.Contact.Phone;

                    int index = dataGridView1.Rows.IndexOf(row);
                    dataGridView1.Rows.RemoveAt(index);
                    dataGridView1.Rows.Insert(index, updatedRow);
                }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count == 0)
                return;

            DataGridViewRow selectedRow = selectedRows[0];
            int id = (int)selectedRow.Cells[0].Value;

            Database.DatabaseHandler.DeleteEmployeeByID(id);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count == 0)
                return;

            DataGridViewRow selectedRow = selectedRows[0];
            int id = (int)selectedRow.Cells[0].Value;

            EmployeeInformation employee = EmployeeInformation.FromDatabase(id);
            Globals.AppState.MenuFormInstance.ShowFormDialog(new ProfileForm(employee));
        }

        private void fieldComboBox_OnValueChanged(object sender, EventArgs e)
        {
            updateTableFilter();
        }

        private void valueTextbox_TextChanged(object sender, EventArgs e)
        {
            updateTableFilter();
        }

        private void updateTableFilter()
        {
            for (int u = 0; u < dataGridView1.RowCount; u++)
            {
                string value = dataGridView1.Rows[u].Cells[fieldComboBox.Value].Value.ToString();
                dataGridView1.Rows[u].Visible = value.Contains(valueTextbox.Text, StringComparison.OrdinalIgnoreCase);
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            string url = Database.DatabaseHandler.GetEmployeeReportURL();
        }
    }
}
