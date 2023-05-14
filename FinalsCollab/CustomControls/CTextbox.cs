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
    [DefaultEvent("TextChanged")]
    public partial class CTextbox : UserControl
    {
        public new event EventHandler TextChanged = delegate { };
        public string LabelText 
        {
            get => label1.Text;
            set => label1.Text = value;
        }
        public new string Text
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }
        public string _Text
        {
            get => Text;
            set => Text = value;
        }

        public bool ReadOnly
        {
            get => BackColor == Color.Gainsboro;
            set
            {
                textBox1.Enabled = !value;

                if (value)
                {
                    textBox1.Cursor = Cursors.Arrow;
                    textBox1.BackColor = Globals.DefaultColors.READONLY_BACKGROUND;
                    BackColor = Globals.DefaultColors.READONLY_BACKGROUND;
                }
                else
                {
                    textBox1.Cursor = Cursors.IBeam;
                    textBox1.BackColor = Color.White;
                    BackColor = Color.White;
                }
            }
        }
        public int MaxLength
        {
            get => textBox1.MaxLength;
            set => textBox1.MaxLength = value;
        }
        public Color ActiveColor { get; set; } = Globals.DefaultColors.THEME_COLOR;
        public Color InactiveColor { get; set; } = Globals.DefaultColors.INACTIVE_COLOR;
        public CTextbox()
        {
            InitializeComponent();
        }
        
        private void _setAsActive(object? sender, EventArgs e)
        {
            label1.ForeColor = ActiveColor;
            textBox1.ForeColor = ActiveColor;
            panel1.BackColor = ActiveColor;
        }

        private void _setAsInactive(object? sender, EventArgs e)
        {
            label1.ForeColor = InactiveColor;
            textBox1.ForeColor = InactiveColor;
            panel1.BackColor = InactiveColor;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e);
        }
    }
}
