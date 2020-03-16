using System.Text;
using System.Windows.Forms;

namespace Mobile
{
    public interface IOutput
    {
        void WriteOn(string text = null, RichTextBox textBox = null, StringBuilder textboxBuilder = null);
        void WriteLine(string text);
    }
}
