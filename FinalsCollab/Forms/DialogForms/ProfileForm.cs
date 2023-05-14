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
    public partial class ProfileForm : Form
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

        public ProfileForm()
        {
            InitializeComponent();
            formNameLabel.Text = $"Add Employee";
            submitButton.Text = "ADD";
        }    

        public ProfileForm(EmployeeInformation employee)
        {
            InitializeComponent();
            formNameLabel.Text = Globals.AppState.LoggedInEmployee.ID == employee.ID ? "Edit Profile" : "Edit Employee";

            loadValue(employee);
        }

        private void loadValue(EmployeeInformation employee)
        {
            idNumericTextbox.Value = employee.ID;

            firstnameTextbox.Text = employee.Name.Firstname;
            middlenameTextbox.Text = employee.Name.Middlename;
            lastnameTextbox.Text = employee.Name.Lastname;


            if (employee.Position == "bhw")
                positionComboBox.Value = "BHW";
            else
                positionComboBox.Value = Globals.FuncTools.ToTitleCase(employee.Position);
            positionComboBox.ReadOnly = Globals.AppState.LoggedInEmployee.Position != "admin";

            emailTextbox.Text = employee.Contact.Email;
            phoneNumericTextbox.Value = long.Parse(employee.Contact.Phone);

            usernameTextbox.Text = employee.Account.Username;
            passwordTextbox.Text = employee.Account.Password;

            pictureBox1.Load(Database.DatabaseHandler.GetProfilePictureUrlByID(employee.ID));
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
                EmployeeInformation employee = getFormDetails();

                switch (submitButton.Text)
                {
                    case "SAVE":
                        employee.UpdateToDatabase();
                        break;
                    case "ADD":
                        employee.AddToDatabase();
                        break;
                }
                
                if (pictureBox1.Image != null)
                    Database.DatabaseHandler.AddProfilePictureByID(employee.ID, pictureBox1.Image);
                else
                    Database.DatabaseHandler.DeleteProfilePictureByID(employee.ID);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (CustomExceptions.UsernameAlreadyExists ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private EmployeeInformation getFormDetails()
        {
            return new EmployeeInformation()
            {
                ID = (int)idNumericTextbox.Value,
                Name = new Name()
                {
                    Firstname = firstnameTextbox.Text,
                    Middlename = middlenameTextbox.Text,
                    Lastname = lastnameTextbox.Text
                },
                Position = positionComboBox.Value.ToLower(),
                Contact = new Contact()
                {
                    Email = emailTextbox.Text,
                    Phone = phoneNumericTextbox.Value.ToString()
                },
                Account = new Account()
                {
                    Username = usernameTextbox.Text,
                    Password = passwordTextbox.Text
                }
            };
        }

        private bool isFormValid()
        {
            if (firstnameTextbox.Text == "" || lastnameTextbox.Text == "")
                return false;

            if (usernameTextbox.Text == "" || passwordTextbox.Text == "")
                return false;

            return true;
        }

        private void cButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PNG Files (*.png)|*.png";
            dialog.Title = "Select a png file";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filename = dialog.FileName;

                pictureBox1.Image = Image.FromFile(filename);
            }
        }

        private void cButton2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
