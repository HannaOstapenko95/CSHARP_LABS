using System;
using System.Text;
using System.Windows.Forms;

namespace Mobile
{
    public class OutPut : IOutput
    {
        public void WriteOn(string text = null, RichTextBox textBox = null, StringBuilder textboxBuilder = null)
        {
            if (textBox == null || text == null || textboxBuilder == null)
            {
                Console.Write(text);
            }
            else
            {
                textboxBuilder.AppendLine(text);
                textBox.Text = textboxBuilder.ToString();
            }
        }
        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
