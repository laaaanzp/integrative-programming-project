using HCMIS.Components;
using HCMIS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCMIS
{
    public partial class SelectPatientForm : Form
    {
        public Patient SelectedPatient;
        private Dictionary<int, Patient> _patients = new Dictionary<int, Patient>();
        #region Resize
        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        const int resizeableThickness = 3;
        
        new Rectangle Left { get { return new Rectangle(0, 0, resizeableThickness, this.ClientSize.Height); } }
        new Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - resizeableThickness, this.ClientSize.Width, resizeableThickness); } }
        new Rectangle Right { get { return new Rectangle(this.ClientSize.Width - resizeableThickness, 0, resizeableThickness, this.ClientSize.Height); } }
        Rectangle BottomLeft { get { return new Rectangle(0, ClientSize.Height - resizeableThickness, resizeableThickness, resizeableThickness); } }
        Rectangle BottomRight { get { return new Rectangle(ClientSize.Width - resizeableThickness, ClientSize.Height - resizeableThickness, resizeableThickness, resizeableThickness); } }
        
        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Dispose();
        }
        
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84)
            {
                Point cursor = PointToClient(Cursor.Position);

                if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }
        
        public void loadData(List<Patient> patients)
        {
            tableGrid.Rows.Clear();
            
            patients.ForEach(patient =>
            {
                _patients.Add(patient.ID, patient);
                tableGrid.Rows.Add(patient.ID, patient.Fullname, patient.TotalVisit);
            });
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (tableGrid.SelectedRows.Count == 0) return;

            int id = (int)tableGrid.SelectedRows[0].Cells[0].Value;
            SelectedPatient = _patients[id];

            DialogResult = DialogResult.OK;
            Dispose();
        }
        #endregion

        #region Draggable
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessge(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void MouseDrag(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessge(Handle, 0x112, 0xf012, 0);
        }
        #endregion

        public SelectPatientForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);

            // Set Maximized Window Size
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }

        public SelectPatientForm(List<Patient> patients)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);

            loadData(patients);

            // Set Maximized Window Size
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }
    }
}
