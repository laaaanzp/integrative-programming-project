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
    public partial class CustomTextBox : UserControl
    {
        //
        public event EventHandler OnValueChanged = delegate { };
        private AutoCompleteStringCollection _autoCompleteSource = new AutoCompleteStringCollection();
        public string LabelName
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public char PasswordChar
        {
            get { return textBox.PasswordChar; }
            set { textBox.PasswordChar = value; }
        }
        public string Value
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
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

        public CustomTextBox()
        {
            InitializeComponent();
        }
        
        public void AddSuggestions(List<string> suggestions)
        {
            suggestions.ForEach((s) =>
            {
                AddSuggestion(s);
            });
        }

        public void AddSuggestion(string suggestion)
        {
            _autoCompleteSource.Add(suggestion);
        }

        public void ToggleSuggestions(bool value)
        {
            if (value)
            {
                textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textBox.AutoCompleteCustomSource = _autoCompleteSource;
                return;
            }

            textBox.AutoCompleteMode = AutoCompleteMode.None;
            textBox.AutoCompleteSource = AutoCompleteSource.None;
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

            if (textBox.AutoCompleteMode == AutoCompleteMode.SuggestAppend)
            {
                foreach (string autoCompleteValue in textBox.AutoCompleteCustomSource)
                {
                    if (textBox.Text.Equals(autoCompleteValue, StringComparison.OrdinalIgnoreCase))
                    {
                        textBox.Text = autoCompleteValue;
                        return;
                    }  
                }
                textBox.Text = "";
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            OnValueChanged(this, e);
        }
    }
}
