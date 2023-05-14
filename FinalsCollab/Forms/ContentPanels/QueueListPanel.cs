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
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalsCollab.Forms.ContentPanels
{
    public partial class QueueListPanel : UserControl
    {
        public QueueListPanel()
        {
            InitializeComponent();

            Database.SocketConnection.OnQueueListAdd += onAdd;
            Database.SocketConnection.OnQueueListRemove += onRemove;

            addButton.Enabled = deleteButton.Enabled =
                Globals.AppState.LoggedInEmployee.Position == "admin" ||
                Globals.AppState.LoggedInEmployee.Position == "nurse";

            approveButton.Enabled =
                Globals.AppState.LoggedInEmployee.Position == "admin" ||
                Globals.AppState.LoggedInEmployee.Position == "doctor";

            loadData();
        }

        private void loadData()
        {
            dataGridView1.Rows.Clear();
            List<Queue> employees = Queue.GetQueues();

            employees.ForEach(addQueueToTable);
        }

        private void onAdd(JObject value)
        {
            addQueueToTable(Queue.FromJObject(value));
        }

        public void onRemove(JObject value)
        {
            removeQueueFromTableByID(value["id"].ToObject<int>());
        }

        private void addQueueToTable(Queue queue)
        {
            removeQueueFromTableByID(queue.ID);
            

            dataGridView1.Rows.Add(
                queue.ID,
                queue.Fullname,
                Globals.FuncTools.ToTitleCase(queue.Reason),
                queue.BloodPressure,
                queue.WeightKG.ToString(),
                queue.HeightFT.ToString(),
                queue.BMI.ToString("0.0")
                );
        }

        private void removeQueueFromTableByID(int id)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
                if (id == (int)row.Cells[0].Value)
                    dataGridView1.Rows.Remove(row);
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            Globals.AppState.MenuFormInstance.ShowFormDialog(new QueueForm());
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

            Queue queue = Queue.FromDatabase(id);
            queue.DeleteFromDatabase();
        }
    }
}
