using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile.CommonObjects.Screen
{
    public interface IScreenTouch
    {
        string SelectScreenTouch(object data = null, StringBuilder textboxBuilder = null, RichTextBox textBox = null);
    }
}
