using HCMIS.Components;
using HCMIS.Database;
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
    public partial class AddQueueForm : Form
    {        
        #region Draggable
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        Patient? _patient = null;

        private void addButton_Click(object sender, EventArgs e)
        {
            if (_patient is null)
            {
                MessageBox.Show(
                    "Please select a patient.",
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                return;
            }

            Queue queue = new Queue(
                0,
                _patient,
                bloodPressureNumericUpDown.Value,
                weightKGNumericTextBox.Value,
                heightFTNumericTextBox.Value,
                reasonComboBox.Value
                );

            DatabaseHandler.DB.AddQueue(queue);

            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessge(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void MouseDrag(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessge(Handle, 0x112, 0xf012, 0);
        }
        #endregion

        public AddQueueForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);


            // Set Maximized Window Size
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }

        private void updateLabels(Patient patient)
        {
            idNumericUpDown.Value = patient.ID;
            fullnameTextBox.Value = patient.Fullname;
            genderLabel.Text = $"Gender: {patient.Gender}";
            emailLabel.Text = $"Email: {patient.Contact.Email}";
            phoneNumberLabel.Text = $"Phone Number: {patient.Contact.PhoneNumber}";
            addressLabel.Text = $"Address: {patient.Address}";
            birthdateLabel.Text = $"Birthday: {patient.Birthday.ToString("MMMM dd, yyyy")}";
            bloodTypeLabel.Text = $"Blood Type: {patient.Bloodtype}";
            maritalStatusLabel.Text = $"Marital Status: {patient.MaritalStatus}";
        }

        private void findPatientByIDButton_Click(object sender, EventArgs e)
        {
            _patient = DatabaseHandler.DB.GetPatient(idNumericUpDown.Value);

            if (_patient is not null)
                updateLabels(_patient);
        }

        private void findPatientByFullnameButton_Click(object sender, EventArgs e)
        {
            List<Patient> patients = DatabaseHandler.DB.GetPatient(fullnameTextBox.Value);

            if (patients.Count == 1)
            {
                updateLabels(patients[0]);
                _patient = patients[0];
            }
            else if (patients.Count == 0)
                return;
            else
            {
                using (SelectPatientForm form = new SelectPatientForm(patients))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        _patient = form.SelectedPatient;
                        updateLabels(_patient);
                    }
                }
            }
        }

        private void calculateBMI(object sender, double e)
        {
            bmiTextBox.Value = Tools.CalculateBMI(weightKGNumericTextBox.Value, heightFTNumericTextBox.Value).ToString("N1");
        }
    }
}
