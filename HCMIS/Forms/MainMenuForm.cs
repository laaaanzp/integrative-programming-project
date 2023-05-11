using HCMIS.Components;
using HCMIS.Interface;
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
    public partial class MainMenuForm : Form
    {
        private Action<object, KeyEventArgs> _onKeyPressEvent = delegate { };

        #region Resize
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.WhiteSmoke, Left);
            e.Graphics.FillRectangle(Brushes.WhiteSmoke, Right);
            e.Graphics.FillRectangle(Brushes.WhiteSmoke, Bottom);
        }

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

        private void toggleMaximizeWindow(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                maximizeButton.BackgroundImage = Properties.Resources.NormalizeButton;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                maximizeButton.BackgroundImage = Properties.Resources.MaximizeButton;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        Rectangle BottomLeft { get { return new Rectangle(0, ClientSize.Height - resizeableThickness, resizeableThickness, resizeableThickness); } }
        Rectangle BottomRight { get { return new Rectangle(ClientSize.Width - resizeableThickness, ClientSize.Height - resizeableThickness, resizeableThickness, resizeableThickness); } }

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

        private void MainMenuForm_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void MainMenuForm_KeyPress(object sender, KeyEventArgs e)
        {
            _onKeyPressEvent(sender, e);
        }

        private Dictionary<Type, Option> _options = new Dictionary<Type, Option>()
        {
            { typeof(DashboardPanel), new Option(
                Properties.Resources.DashboardActive,
                Properties.Resources.DashboardInactive,
                "Dashboard",
                new DashboardPanel()
                ) },
            { typeof(QueueListPanel), new Option(
                Properties.Resources.DashboardActive,
                Properties.Resources.DashboardInactive,
                "Queue",
                new QueueListPanel()
                ) },
            { typeof(RecordListPanel), new Option(
                Properties.Resources.DashboardActive,
                Properties.Resources.DashboardInactive,
                "Records",
                new RecordListPanel()
                ) },
            { typeof(PatientListPanel), new Option(
                Properties.Resources.DashboardActive,
                Properties.Resources.DashboardInactive,
                "Patients",
                new PatientListPanel()
                ) },
            { typeof(EmployeeListPanel), new Option(
                Properties.Resources.DashboardActive,
                Properties.Resources.DashboardInactive,
                "Employees",
                new EmployeeListPanel()
                ) }
        };

        public MainMenuForm(Employee information)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);

            Globals.MainMenuFormRef = this;

            Panel[] optionPanels = {
                option1, option2, option3, option4,
                option5, option6, option7, option8
            };

            List<Type> options = Tools.GetOptionsByJobPosition(information.Position);
            options.ForEach(t =>
            {
                UserControl control = (UserControl)Activator.CreateInstance(t);
                int index = options.FindIndex(a => a == t);

                optionPanels[index].Cursor = Cursors.Hand;

                bool active = index == 0 ? true : false;
                AddOptionToContainer(_options[t], optionPanels[index], active);
            });

            nameLabel.Text = information.Name.FirstName;
            positionLabel.Text = information.Position.ToString().Replace('_', ' ');
            

            // Set Maximized Window Size
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }
        
        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginWindow = new LoginForm();
            loginWindow.Show();
            Hide();
        }
       
        public void AddOptionToContainer(Option option, Control parent, bool active)
        {
            Tools.AddControlToParent(
                new OptionPanel(
                    option,
                    () =>
                    {
                        Tools.AddControlToParent(option.Control, mainContentPanel);
                        if (option.Control is IKeyPressListener)
                        {
                            _onKeyPressEvent = ((IKeyPressListener)option.Control).OnKeyPress;
                        }
                    }, 
                    active),
                parent
                );
        }
    }
}
