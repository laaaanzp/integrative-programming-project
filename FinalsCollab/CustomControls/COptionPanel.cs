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
    public partial class COptionPanel : UserControl
    {
        private static readonly List<COptionPanel> _instances = new List<COptionPanel>();
        public Action<string> Changer { get; set; } = delegate { };
        public string LabelText 
        { 
            get => label1.Text; 
            set => label1.Text = value; 
        }
        public Color ActiveColor { get; set; } = Globals.DefaultColors.THEME_COLOR;
        public Color InactiveColor { get; set; } = Globals.DefaultColors.INACTIVE_COLOR;

        public COptionPanel(bool activated = false)
        {
            InitializeComponent();

            _instances.Add(this);

            if (activated)
                Activate();
            else
                Inactivate();
        }

        private void Activate()
        {
            panel1.BackColor = ActiveColor;
            label1.ForeColor = ActiveColor;
            BackColor = Color.WhiteSmoke;

            _instances.ForEach(o =>
            {
                if (o == this)
                    return;

                o.Inactivate();
            });
        }

        private void Inactivate()
        {
            panel1.BackColor = InactiveColor;
            label1.ForeColor = InactiveColor;
            BackColor = Color.White;
        }

        private void OnClick(object sender, EventArgs e)
        {
            Changer(LabelText);
            Activate();
        }
    }
}
