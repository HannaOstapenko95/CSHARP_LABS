using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile
{
    public interface ICharger
    {
        string Charge(object data = null, StringBuilder textboxBuilder = null, RichTextBox textBox = null);
    }
}
