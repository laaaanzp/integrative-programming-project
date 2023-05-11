using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCMIS.Components
{
    public partial class CustomComboBox : UserControl
    {
        public event EventHandler OnValueChanged = delegate { };

        [Category("Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items { 
            get => comboBox.Items;
            set
            {
                comboBox.Items.Clear();
                foreach (object item in value)
                {
                    comboBox.Items.Add(item);
                }
            }
        }
        public string LabelText
        {
            get => label1.Text;
            set => label1.Text = value;
        }
        public string Value
        {
            get => comboBox.SelectedItem != null ? comboBox.SelectedItem.ToString() : "";
            set => comboBox.SelectedItem = value;
        }
        public bool ReadOnly
        {
            get => !comboBox.Enabled;
            set 
            {
                comboBox.Enabled = !value;
                comboBox.BackColor = Color.White;
            }
        }

        public CustomComboBox()
        {
            InitializeComponent();
        }
        
        public void AddItems(List<string> items)
        {
            items.ForEach((s) =>
            {
                AddItem(s);
            });
        }

        public void AddItem(string item)
        {
            comboBox.Items.Add(item);
        }

        
        public void Clear()
        {
            comboBox.SelectedItem = null;
        }

        public new void Focus()
        {
            comboBox.Focus();
        }

        private void comboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            OnValueChanged(sender, e);
        }
    }
}
