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
    public partial class AddEmployeeForm : Form
    {
        #region Draggable
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void addButton_Click(object sender, EventArgs e)
        {
            JobPosition position;

            if (!Enum.TryParse(jobPosition.Value, out position))
            {
                position = JobPosition.Barangay_Health_Worker;
            }

            Name name = new Name(firstName.Value, middleName.Value, lastName.Value);
            Account account = new Account(username.Value, password.Value);
            Contact contact = new Contact(email.Value, phoneNumber.Value);
            Employee employee = new Employee(0, name, account, position, contact);

            bool success = DatabaseHandler.DB.RegisterEmployee(employee);
                
            DialogResult = success ? DialogResult.OK : DialogResult.Abort;
            Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessge(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void MouseDrag(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessge(Handle, 0x112, 0xf012, 0);
        }
        #endregion

        public AddEmployeeForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);


            // Set Maximized Window Size
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }
    }
}
