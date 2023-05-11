using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCMIS.Interface
{
    public interface IKeyPressListener
    {
        public void OnKeyPress(object sender, KeyEventArgs e);
    }
}
