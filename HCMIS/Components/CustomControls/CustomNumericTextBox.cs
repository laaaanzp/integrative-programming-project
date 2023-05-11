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
    public partial class CustomNumericTextBox : UserControl
    {
        public event EventHandler<double> OnValueChanged = delegate { };
        public string LabelName
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public double Value
        {
            get {
                try
                {
                    return double.Parse(textBox.Text);
                }
                catch
                {
                    return 0;
                }
            }
            set { textBox.Text = value.ToString(); }
        }
        public bool ReadOnly
        {
            get { return !textBox.Enabled; }
            set 
            {
                textBox.Enabled = !value;
                textBox.BackColor = Color.White;
            }
        }

        public CustomNumericTextBox()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            textBox.Text = "";
        }

        public new void Focus()
        {
            textBox.Focus();
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            borderPanel.BackColor = Color.FromArgb(255, 41, 193, 140);
            label1.ForeColor = Color.FromArgb(255, 41, 193, 140);
            textBox.ForeColor = Color.FromArgb(255, 41, 193, 140);
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            borderPanel.BackColor = Color.Gray;
            label1.ForeColor = Color.Gray;
            textBox.ForeColor = Color.Gray;

            while (textBox.Text.EndsWith("."))
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            }

            try
            {
                double.Parse(textBox.Text);
            }
            catch
            {
                textBox.Text = "";
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            OnValueChanged(this, 0d);
        }
    }
}
