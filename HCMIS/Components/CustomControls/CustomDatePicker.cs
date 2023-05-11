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
    public partial class CustomDatePicker : UserControl
    {
        public event EventHandler<DateOnly> OnValueChanged = delegate { };

        public CustomDatePicker()
        {
            InitializeComponent();
            datePicker.MaxDate = DateTime.Today;
        }

        private void datePicker_CloseUp(object sender, EventArgs e)
        {
            OnValueChanged(this, DateOnly.FromDateTime(datePicker.Value));
        }

        private void chooseDateButton_Click(object sender, EventArgs e)
        {
            datePicker.Select();
            SendKeys.Send("%{DOWN}");
        }
    }
}
