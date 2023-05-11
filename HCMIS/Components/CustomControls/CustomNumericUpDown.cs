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
    public partial class CustomNumericUpDown : UserControl
    {
        public event EventHandler<string> OnValueChange = delegate { };

        public int Minimum { get; set; } = 0;
        public int Maximum { get; set; } = 100;
        public bool TimeFormat { get; set; }
        public string LabelName
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public int Value
        {
            get
            {
                try
                {
                    return int.Parse(textBox.Text);
                }
                catch (Exception)
                {
                    return 0;
                }
            }
            set
            {
                OnValueChange(this, Value.ToString());
                if (value < Minimum || value > Maximum)
                {
                    return;
                }

                textBox.Text = value.ToString();
                ValidateText();
            }
        }
        
        public string RawText
        {
            get { return textBox.Text; }
        }

        public bool ReadOnly
        {
            get => !textBox.Enabled;
            set
            {
                textBox.Enabled = !value;
                textBox.ForeColor = !value ? Color.DimGray : Color.White;
                incrementButton.Enabled = !value;
                decrementButton.Enabled = !value;
                textBox.BackColor = Color.White;
            }
        }

        public void ValidateText()
        {
            if (!TimeFormat)
            {
                return;
            }

            string text = textBox.Text;
            if (text.Length == 1)
            {
                textBox.Text = "0" + text;
            }
        }

        public CustomNumericUpDown()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            textBox.Text = Minimum.ToString();
            ValidateText();
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

            ValidateText();
        }

        private void incrementButton_Click(object sender, EventArgs e)
        {
            if (Value == Maximum)
            {
                Value = Minimum;
                return;
            }
            this.Value += 1;
        }

        private void decrementButton_Click(object sender, EventArgs e)
        {
            if (Value == Minimum)
            {
                Value = Maximum;
                return;
            }

            Value -= 1;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char)Keys.Back;

            try
            {
                int value = int.Parse(textBox.Text + e.KeyChar);
                e.Handled = value < Minimum || value > Maximum;
            }
            catch (Exception) { }
        }
    }
}
