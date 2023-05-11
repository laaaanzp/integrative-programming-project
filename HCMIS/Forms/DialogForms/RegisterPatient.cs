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
    public partial class RegisterPatient : Form
    {        
        #region Draggable
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessge(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void MouseDrag(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessge(Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void addButton_Click(object sender, EventArgs e)
        {
            if (bdayDay.Value.Length == 1)
                bdayDay.Value = $"0{bdayDay.Value}";

            Patient patient = new Patient(
                0,
                fullnameTextBox.Value,
                genderComboBox.Value,
                new Contact(emailTextBox.Value, phoneNumberTextBox.Value),
                DateTime.ParseExact($"{bdayMonth.Value} {bdayDay.Value}, {bdayYear.Value}", "MMMM dd, yyyy", System.Globalization.CultureInfo.InvariantCulture),
                addressTextBox.Value,
                bloodTypeComboBox.Value,
                maritalStatusComboBox.Value,
                numberOfKidsNumericUpDown.Value
                );

            DatabaseHandler.DB.RegisterPatient(patient);

            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Dispose();
        }
        
        public RegisterPatient()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);

            numberOfKidsNumericUpDown.ReadOnly = true;
            fullnameTextBox.Focus();
            
            // Set Maximized Window Size
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }

        private void SetBirthdayDate(object _, DateOnly date)
        {
            string month = Globals.Months[date.Month - 1];
            string day = date.Day.ToString();
            string year = date.Year.ToString();

            bdayMonth.Value = month;
            bdayDay.Value = day;
            bdayYear.Value = year;
        }

        private void maritalStatusComboBox_OnValueChanged(object sender, EventArgs e)
        {
            numberOfKidsNumericUpDown.ReadOnly = maritalStatusComboBox.Value == "Single";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            fullnameTextBox.Clear();
            genderComboBox.Clear();

            emailTextBox.Clear();
            phoneNumberTextBox.Clear();

            addressTextBox.Clear();

            bdayMonth.Clear();
            bdayDay.Clear();
            bdayYear.Clear();

            bloodTypeComboBox.Clear();
            maritalStatusComboBox.Clear();
            numberOfKidsNumericUpDown.Clear();
        }
    }
}
