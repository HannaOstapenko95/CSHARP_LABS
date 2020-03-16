using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile.Case
{
    public interface ICase
    {
        string SelectCase(object data = null, StringBuilder textboxBuilder = null, RichTextBox textBox = null);
    }
}
