using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalsCollab.CustomControls
{
    public partial class CDashboardContent : UserControl
    {
        public Color SidebarColor { get; set; } = Globals.DefaultColors.THEME_COLOR;
        public Color LabelColor { get; set; } = Globals.DefaultColors.INACTIVE_COLOR;
        public string LabelText 
        { 
            get => label1.Text;
            set => label1.Text = value;
        }
        public string ValueText 
        { 
            get => label2.Text;
            set 
            {
                if (label2.InvokeRequired)
                    Invoke(new MethodInvoker(() => label2.Text = value));
                else
                    label2.Text = value;
            }   
        }

        public CDashboardContent()
        {
            InitializeComponent();

            panel1.BackColor = SidebarColor;
            label1.ForeColor = LabelColor;
        }
    }
}
