using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalsCollab.CustomControls;
using FinalsCollab.Forms.ContentPanels;
using FinalsCollab.Forms.DialogForms;
using FinalsCollab.Models;
using Newtonsoft.Json.Linq;

namespace FinalsCollab.Forms
{
    public partial class MenuForm : Form
    {
        private Dictionary<string, UserControl> _tabPanels = new Dictionary<string, UserControl>()
        {
            { "Dashboard", new DashboardPanel() },
            { "Record List", new RecordListPanel() },
            { "Queue List", new QueueListPanel() },
            { "Patient List", new PatientListPanel() },
            { "Employee List", new EmployeeListPanel() }
        };

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        const int resizeableThickness = 3;

        new Rectangle Left { get => new Rectangle(0, 0, resizeableThickness, ClientSize.Height); }
        new Rectangle Bottom { get => new Rectangle(0, ClientSize.Height - resizeableThickness, ClientSize.Width, resizeableThickness); }
        new Rectangle Right { get => new Rectangle(ClientSize.Width - resizeableThickness, 0, resizeableThickness, ClientSize.Height); }
        Rectangle BottomLeft { get => new Rectangle(0, ClientSize.Height - resizeableThickness, resizeableThickness, resizeableThickness); }
        Rectangle BottomRight { get => new Rectangle(ClientSize.Width - resizeableThickness, ClientSize.Height - resizeableThickness, resizeableThickness, resizeableThickness); }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84)
            {
                Point cursor = PointToClient(Cursor.Position);

                if 
                    (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if 
                    (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;
                else if 
                    (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if 
                    (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if 
                    (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }

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

        private void ToggleFullscreen()
        {
            if (WindowState != FormWindowState.Maximized)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Globals.DefaultColors.BORDER_COLOR, ButtonBorderStyle.Solid);
        }

        private readonly Dictionary<string, string[]> _options = new Dictionary<string, string[]>()
        {
            { "admin",  new string[] { "Dashboard", "Record List", "Queue List", "Patient List", "Employee List" } },
            { "doctor", new string[] { "Dashboard", "Record List", "Queue List", "Patient List" } },
            { "nurse",  new string[] { "Dashboard", "Queue List", "Patient List" } },
            { "bhw",    new string[] { "Dashboard", "Patient List" } }
        };        
        private readonly Queue<Panel> _optionPanels = new Queue<Panel>();

        public MenuForm()
        {
            InitializeComponent();

            changeContentPanel("Dashboard");
            _optionPanels.Enqueue(optionPanel1);
            _optionPanels.Enqueue(optionPanel2);
            _optionPanels.Enqueue(optionPanel3);
            _optionPanels.Enqueue(optionPanel4);
            _optionPanels.Enqueue(optionPanel5);
            _optionPanels.Enqueue(optionPanel6);

            string position = Globals.AppState.LoggedInEmployee.Position;

            loadOptions(_options[position]);

            updateProfileInformation();
            Globals.AppState.MenuFormInstance = this;
        }

        private void updateProfileInformation()
        {
            string fullname = Globals.AppState.LoggedInEmployee.Name.Fullname;
            string position = Globals.AppState.LoggedInEmployee.Position;
            int id = Globals.AppState.LoggedInEmployee.ID;

            nameLabel.Text = fullname;
            positionLabel.Text = position == "bhw" ? "BARANGAY HEALTH WORKER" : position.ToUpper();
            // TODO: profileImagePictureBox.Load(Database.DatabaseHandler.GetProfilePictureUrlByID(id));
        }

        private void editButtonClick(object sender, EventArgs e)
        {
            ShowFormDialog(new ProfileForm(Globals.AppState.LoggedInEmployee));
        }

        private void logoutButtonClick(object sender, EventArgs e)
        {
            Globals.AppState.LoggedInEmployee = null;
            new LoginForm().Show();
            Hide();
        }

        private void formNameLabel_DoubleClick(object sender, EventArgs e)
        {
            ToggleFullscreen();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadOptions(string[] options)
        {
            foreach (string optionString in options)
            {
                Panel panel = _optionPanels.Dequeue();
                COptionPanel option = new COptionPanel(panel == optionPanel1)
                {
                    LabelText = optionString,
                    Changer = changeContentPanel
                };

                addControlToParent(option, panel);
            }
        }

        private void addControlToParent(Control control, Control parent)
        {
            parent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            parent.Controls.Add(control);
        }

        private void changeContentPanel(string panelName)
        {
            mainContentPanel.Controls.Clear();

            UserControl panel = _tabPanels[panelName];
            panel.Dock = DockStyle.Fill;
            mainContentPanel.Controls.Add(panel);
        }

        public DialogResult ShowFormDialog(Form form)
        {
            using (form)
            {
                Form dimForm = new Form()
                {
                    StartPosition = FormStartPosition.Manual,
                    FormBorderStyle = FormBorderStyle.None,
                    Opacity = .50d,
                    BackColor = Color.White,
                    Size = Size,
                    Location = Location,
                    ShowInTaskbar = false,
                };
                dimForm.Show();
                dimForm.Owner = this;
                form.Owner = dimForm;

                try { return form.ShowDialog(); }
                finally
                { 
                    dimForm.Close();
                    Focus();
                }
            }
        }
    }
}
