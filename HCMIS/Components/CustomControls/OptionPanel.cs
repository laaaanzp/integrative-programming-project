using HCMIS.Models;
using System;
using System.Collections;
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
    public partial class OptionPanel : UserControl
    {
        private static List<OptionPanel> _instances = new List<OptionPanel>();
        private Action _onClick;
        private Image _activeImage;
        private Image _inactiveImage;

        public OptionPanel(Option option, Action onClick, bool active)
        {
            InitializeComponent();

            label1.Text = option.LabelName;
            _onClick = onClick;
            iconBox.BackgroundImage = option.InactiveImage;

            _activeImage = option.ActiveImage;
            _inactiveImage = option.InactiveImage;

            if (active)
            {
                OnClick();
            }

            _instances.Add(this);
        }

        private void OnClick(object? sender = null, EventArgs? e = null)
        {
            SetAsActive();
            _onClick();
        }

        public void SetAsActive()
        {
            BackColor = Color.FromArgb(255, 245, 245, 245);
            borderPanel.BackColor = Color.FromArgb(255, 41, 193, 140);
            label1.ForeColor = Color.FromArgb(255, 41, 193, 140);
            iconBox.BackgroundImage = _activeImage;

            _instances.ForEach(n =>
            {
                if (n != this)
                {
                    n.SetAsInactive();
                }
            });
        }
        
        public void SetAsInactive()
        {
            BackColor = Color.FromArgb(255, 235, 235, 235);
            borderPanel.BackColor = Color.FromArgb(255, 235, 235, 235);
            label1.ForeColor = Color.Gray;
            iconBox.BackgroundImage = _inactiveImage;
        }
    }
}
