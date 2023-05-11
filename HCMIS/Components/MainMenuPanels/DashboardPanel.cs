using HCMIS.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCMIS.Components
{
    public partial class DashboardPanel : UserControl, IKeyPressListener
    {
        public DashboardPanel()
        {
            InitializeComponent();
        }

        public void OnKeyPress(object sender, KeyEventArgs e)
        {

        }
    }
}
