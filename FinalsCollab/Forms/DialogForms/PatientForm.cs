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
    public partial class PatientForm : Form
    {
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

        public PatientForm()
        {
            InitializeComponent();
            formNameLabel.Text = "Add Patient";
            submitButton.Text = "ADD";
        }    

        public PatientForm(PatientInformation patient)
        {
            InitializeComponent();
            formNameLabel.Text = "Edit Patient";

            loadValue(patient);
        }

        private void loadValue(PatientInformation patient)
        {
            idNumericTextbox.Value = patient.ID;
            fullnameTextbox.Text = patient.Fullname;
            birthdayTextbox.Text = patient.Birthday.ToString("MMMM d, yyyy");

            addressTextbox.Text = patient.Address;
            

            genderComboBox.Value = Globals.FuncTools.ToTitleCase(patient.Gender);
            bloodtypeComboBox.Value = patient.BloodType;
            maritalStatusComboBox.Value = Globals.FuncTools.ToTitleCase(patient.MaritalStatus);
            numberOfKidsNumericTextbox.Value = patient.NumberOfKids;

            emailTextbox.Text = patient.Contact.Email;
            phoneNumericTextbox.Text = patient.Contact.Phone;
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
                PatientInformation patient = getFormDetails();

                switch (submitButton.Text)
                {
                    case "SAVE":
                        patient.UpdateToDatabase();
                        break;
                    case "ADD":
                        patient.AddToDatabase();
                        break;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (CustomExceptions.UsernameAlreadyExists ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private PatientInformation getFormDetails()
        {
            return new PatientInformation()
            {
                ID = (int)idNumericTextbox.Value,
                Fullname = fullnameTextbox.Text,
                Gender = genderComboBox.Value.ToLower(),
                Address = addressTextbox.Text,
                Birthday = DateTime.ParseExact(birthdayTextbox.Text, "MMMM d, yyyy", System.Globalization.CultureInfo.InvariantCulture),
                BloodType = bloodtypeComboBox.Value,
                MaritalStatus = maritalStatusComboBox.Value.ToLower(),
                NumberOfKids = (int)numberOfKidsNumericTextbox.Value,
                Contact = new Contact()
                {
                    Email = emailTextbox.Text,
                    Phone = phoneNumericTextbox.Text
                }
            };
        }

        private bool isFormValid()
        {
            if (fullnameTextbox.Text == "" || birthdayTextbox.Text == "")
                return false;

            if (genderComboBox.Value == "" || bloodtypeComboBox.Value == "" || maritalStatusComboBox.Value == "")
                return false;

            return true;
        }

        private void cDatePicker1_OnValueChanged(object sender, DateOnly e)
        {
            birthdayTextbox.Text = e.ToString("MMMM d, yyyy");
        }
    }
}
