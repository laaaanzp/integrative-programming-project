using HCMIS.Components;
using HCMIS.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data.Common;
using System.Text.Json;

namespace HCMIS
{
    public class Tools
    {
        public static DataGridView CloneDataGrid(DataGridView mainDataGridView)
        {
            DataGridView cloneDataGridView = new DataGridView();

            if (cloneDataGridView.Columns.Count == 0)
            {
                foreach (DataGridViewColumn datagrid in mainDataGridView.Columns)
                {
                    cloneDataGridView.Columns.Add(datagrid.Clone() as DataGridViewColumn);
                }
            }

            DataGridViewRow dataRow = new DataGridViewRow();

            for (int i = 0; i < mainDataGridView.Rows.Count; i++)
            {
                dataRow = (DataGridViewRow)mainDataGridView.Rows[i].Clone();
                int Index = 0;
                foreach (DataGridViewCell cell in mainDataGridView.Rows[i].Cells)
                {
                    dataRow.Cells[Index].Value = cell.Value;
                    Index++;
                }
                cloneDataGridView.Rows.Add(dataRow);
            }
            cloneDataGridView.AllowUserToAddRows = false;
            cloneDataGridView.Refresh();


            return cloneDataGridView;
        }

        public static void SaveDataGridToFileAsPDF(DataGridView dataGrid, string headerText)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PDF File (*.pdf)|*.pdf";

            if (dialog.ShowDialog() != DialogResult.OK) 
                return;

            using (FileStream fs = new FileStream(dialog.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {            
                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                document.Open();

                PdfPTable table = new PdfPTable(dataGrid.Columns.Count);
                table.DefaultCell.Padding = 2;
                table.WidthPercentage = 100;
                table.HorizontalAlignment = Element.ALIGN_LEFT;
            
                foreach (DataGridViewColumn column in dataGrid.Columns)
                {
                    BaseFont headerBaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font headerFont = new iTextSharp.text.Font(headerBaseFont, 10, 1, new BaseColor(Color.White));
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText.ToUpper(), headerFont));
                    cell.BackgroundColor = new BaseColor(Color.FromArgb(41, 193, 140));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
            
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    { 
                        BaseFont headerBaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                        iTextSharp.text.Font headerFont = new iTextSharp.text.Font(headerBaseFont, 8, 1, new BaseColor(Color.Black));

                        string textValue = "";
                        if (cell.Value.ToString() != null)
                            textValue = cell.Value.ToString();

                        PdfPCell value = new PdfPCell(new Phrase(textValue, headerFont));
                        table.AddCell(value);
                    }
                }    

                BaseFont bfntHead = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfntHead, 25, 1, new BaseColor(Color.Black));
                Paragraph prgHeading = new Paragraph();
                prgHeading.Alignment = Element.ALIGN_CENTER;
                prgHeading.Add(new Chunk(headerText, fntHead));
                document.Add(prgHeading);

                Paragraph prgAuthor = new Paragraph();
                BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font fntAuthor = new iTextSharp.text.Font(btnAuthor, 10, 2, new BaseColor(Color.Gray));
                prgAuthor.Alignment = Element.ALIGN_LEFT;
                prgAuthor.Add(new Chunk("As of " + DateTime.Now.ToShortDateString(), fntAuthor));
                document.Add(prgAuthor);

                Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, new BaseColor(Color.Gray), Element.ALIGN_LEFT, 1)));
                document.Add(p);

                document.Add(table);

                document.Close();
                writer.Close();
            }

        }

        public static Dictionary<string, Type> options = new Dictionary<string, Type>()
        {
            { "Dashboard", typeof(DashboardPanel) },
            { "Queue", typeof(QueueListPanel) },
            { "Records", typeof(RecordListPanel)},
            { "Patients", typeof(PatientListPanel) },
            { "Employees", typeof(EmployeeListPanel) }
        };

        public static double CalculateBMI(double weightKG, double heightFT)
        {
            double heightAsMeters = heightFT / (double)3.281m;
            double bmi = weightKG / (heightAsMeters * heightAsMeters);

            return bmi; 
        }

        public static List<Type> GetOptionsByJobPosition(JobPosition position)
        {
            List<Type> opts = new List<Type>();
            if (position == JobPosition.Admin)
            {
                foreach (string option in options.Keys.ToArray())
                {
                    opts.Add(options[option]);
                }

                return opts;
            }

            string filename = "JobPositionOptions.json";
            string jsonString = File.ReadAllText(filename);
            EmployeeOptions[]? empsOpts = JsonSerializer.Deserialize<EmployeeOptions[]>(jsonString);
            
            if (empsOpts == null)
            {
                return opts;
            }

            foreach (EmployeeOptions empOpts in empsOpts)
            {
                if (empOpts.JobPosition == position.ToString())
                {
                    foreach (string option in empOpts.Options)
                    {
                        opts.Add(options[option]);
                    }
                }
            }

            return opts;
        }

        public static string GetConnectionString(string databaseFilepath)
        {
            return
                $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={databaseFilepath};" +
                "Integrated Security=True;Connect Timeout=30;";
        }

        public static string GetConnectionStringMaster()
        {
            return
                $"Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=master;" +
                "Integrated Security=True;Connect Timeout=30;";
        }

        public static JobPosition ParsePosition(string position)
        {
            switch (position)
            {
                case "Admin":
                    return JobPosition.Admin;
                case "Doctor":
                    return JobPosition.Doctor;
                case "Nurse":
                    return JobPosition.Nurse;
                default:
                    return JobPosition.Barangay_Health_Worker;
            }
        }
        public static void AddControlToParent(Control control, Control parent)
        {
            control.Dock = DockStyle.Fill;
            parent.Controls.Clear();
            parent.Controls.Add(control);
            control.TabIndex = parent.TabIndex;
        }

        public static int GetAgeFromNow(DateTime birthdate)
        {
            DateTime today = DateTime.Today;

            int a = (today.Year * 100 + today.Month) * 100 + today.Day;
            int b = (birthdate.Year * 100 + birthdate.Month) * 100 + birthdate.Day;

            return (a - b) / 10000;
        }
    }
}
