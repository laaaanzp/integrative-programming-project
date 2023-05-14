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
using FinalsCollab.CustomControls;
using FinalsCollab.Models;

namespace FinalsCollab.Forms.DialogForms
{
    public partial class QueueForm : Form
    {
        private int _patientID = 0;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Drag(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Globals.DefaultColors.BORDER_COLOR, ButtonBorderStyle.Solid);
        }

        public QueueForm()
        {
            InitializeComponent();
            formNameLabel.Text = $"Add Employee";
            submitButton.Text = "ADD";
        }    

        private void loadValue(EmployeeInformation employee)
        {
            patientIdNumericTextbox.Value = employee.ID;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (!isFormValid())
            {
                MessageBox.Show("Please complete the form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Queue queue = getFormDetails();
                queue.AddToDatabase();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch
            {
                MessageBox.Show("Queue has been approved from another system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private Queue getFormDetails()
        {
            return new Queue()
            {
                ID = 0,
                PatientID = (int)patientIdNumericTextbox.Value,
                BloodPressure = bloodPressureTextbox.Text,
                WeightKG = (int)weightKgNumericTextbox.Value,
                HeightFT = heightFtNumericTextbox.Value,
                Reason = reasonComboBox.Value.ToLower()
            };
        }

        private bool isFormValid()
        {
            if (_patientID == 0)
                return false;

            if (bloodPressureTextbox.Text == "")
                return false;

            if (weightKgNumericTextbox.Value == 0) 
                return false;

            if (heightFtNumericTextbox.Value == 0)
                return false;

            return true;
        }

        private void cNumericTextbox1_TextChanged(object sender, EventArgs e)
        {
            updateBMI();
        }

        private void cNumericTextbox21_TextChanged(object sender, EventArgs e)
        {
            updateBMI();
        }

        private void updateBMI()
        {
            try
            {
                double bmi = Globals.FuncTools.CalculateBMI((int)weightKgNumericTextbox.Value, heightFtNumericTextbox.Value);
                bmiNumericTextbox.Text = bmi.ToString("0.0");
            }
            catch { bmiNumericTextbox.Text = ""; }
        }

        private void cButton1_Click(object sender, EventArgs e)
        {
            int patientID = (int)patientIdNumericTextbox.Value;

            try
            {
                PatientInformation patient = PatientInformation.FromDatabase(patientID);
                _patientID = patient.ID;
                fullnameTextbox.Text = patient.Fullname;
            }
            catch (CustomExceptions.DataNotFound ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
