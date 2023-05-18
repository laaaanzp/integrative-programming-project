using FinalsCollab.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalsCollab.Forms.ContentPanels
{
    public partial class RecordListPanel : UserControl
    {
        public RecordListPanel()
        {
            InitializeComponent();

            deleteButton.Enabled =
                Globals.AppState.LoggedInEmployee.Position == "admin";
        }

        private void loadData()
        {
            dataGridView1.Rows.Clear();
            List<Record> records = Record.GetRecords();

            records.ForEach(addRecordToTable);
        }

        private void addRecordToTable(Record record)
        {
            removeRecordFromTableByID(record.ID);

            dataGridView1.Rows.Add(
                record.ID,
                record.Patient.Name,
                record.VisitDateTime.ToString("MMMM d, yyyy"),
                record.VisitDateTime.ToString("hh:mm t"),
                record.AssignedWorker.Name.Fullname,
                Globals.FuncTools.ToTitleCase(record.Reason),
                record.Patient.ID,
                record.BloodPressure,
                record.WeightKG.ToString(),
                record.HeightFT.ToString(),
                record.Deferred ? "Yes" : "No"
                );
        }

        private void removeRecordFromTableByID(int id)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
                if (id == (int)row.Cells[0].Value)
                    dataGridView1.Rows.Remove(row);
        }
    }
}
