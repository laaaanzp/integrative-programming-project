using HCMIS.Database;
using HCMIS.Interface;
using HCMIS.Models;
using System.Windows;
using System.Windows.Forms;

namespace HCMIS.Components
{
    public partial class EmployeeListPanel : UserControl, IKeyPressListener
    {
        public EmployeeListPanel()
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
                case Keys.Delete:
                    removeRow();
                    break;
            }
        }

        private void loadData()
        {
            tableGrid.Rows.Clear();
            List<Employee> employees = DatabaseHandler.DB.GetEmployees();
            employees.ForEach(i =>
            {
                tableGrid.Rows.Add(
                    i.ID,
                    i.Name.FirstName,
                    i.Name.MiddleName,
                    i.Name.LastName,
                    i.Position.ToString().Replace('_', ' '),
                    i.Account.Username,
                    i.Account.Password,
                    i.Contact.Email,
                    i.Contact.PhoneNumber
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
                ) != DialogResult.OK) return;


            DatabaseHandler.DB.RemoveEmployee(id);
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
            using (AddEmployeeForm form = new AddEmployeeForm())
            {
                Globals.MainMenuFormRef.Opacity = .95;

                if (form.ShowDialog() == DialogResult.OK)
                    loadData();
            }

            Globals.MainMenuFormRef.Opacity = 1;
        }

        private void tableGrid_SelectionChanged(object sender, EventArgs e)
        {
            removeButton.Enabled = tableGrid.SelectedRows.Count > 0;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            DataGridView data = Tools.CloneDataGrid(tableGrid);
            data.Columns.RemoveAt(5);
            data.Columns.RemoveAt(5);
            Tools.SaveDataGridToFileAsPDF(data, "Employee List");
        }
    }
}
