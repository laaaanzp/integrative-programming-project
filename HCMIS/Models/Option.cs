using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCMIS.Models
{
    public class Option
    {
        public Image ActiveImage;
        public Image InactiveImage;
        public string LabelName;
        public UserControl Control;

        public Option(Image activeImage, Image inactiveImage, string labelName, UserControl control)
        {
            ActiveImage = activeImage;
            InactiveImage = inactiveImage;
            LabelName = labelName;
            Control = control;
        }
    }
}
