using FinalsCollab.Database;
using FinalsCollab.Forms;
using FinalsCollab.Models;

namespace FinalsCollab
{
    public partial class LoginForm : Form
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            ActiveControl = null;
        }

        private void LoginForm_Deactivate(object sender, EventArgs e)
        {
            ActiveControl = null;
        }


        public LoginForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Account credentials = new Account()
            {
                Username = usernameTextbox.Text,
                Password = passwordTextbox.Text
            };

            try
            {
                EmployeeInformation employee = EmployeeInformation.FromLogin(credentials);
                Globals.AppState.LoggedInEmployee = employee;

                if (rememberCredentialsCheckBox.Checked)
                {
                    Properties.Settings.Default.Username = employee.Account.Username;
                    Properties.Settings.Default.Password = employee.Account.Password;
                    Properties.Settings.Default.Save();
                }

                new MenuForm().Show();
                Hide();
            }
            catch (CustomExceptions.InvalidCredentials ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    
    }
}