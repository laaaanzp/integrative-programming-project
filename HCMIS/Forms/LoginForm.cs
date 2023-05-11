using HCMIS;
using HCMIS.Components;
using HCMIS.Database;
using HCMIS.Models;
using System.Runtime.InteropServices;
using System.Threading;

namespace HCMIS
{
    public partial class LoginForm : Form
    {
        #region Draggable thingy
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessge(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion

        public LoginForm()
        {
            InitializeComponent();
            DatabaseHandler.Initialize();
        }

        private void MouseDrag(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessge(Handle, 0x112, 0xf012, 0);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Account account = new Account(
                usernameTextBox.Value, 
                passwordTextBox.Value
                );

            Employee? information = DatabaseHandler.DB.Login(account);

            if (information is null)
            {
                MessageBox.Show(
                    "Invalid username or password!", 
                    "Login Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                    );
                return;
            }
            Cursor = Cursors.Default;

            Globals.LoggedInEmployee = information;
            MainMenuForm mainMenuWindow = new MainMenuForm(information);
            mainMenuWindow.Show();
            Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            usernameTextBox.Focus();
        }
    }
}