using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile.Case
{
    public class BookCase : ICase
    {
        private IOutput Output;
        public BookCase(IOutput output)
        {
            Output = output;
        }
        public string SelectCase(object data = null, StringBuilder textboxBuilder = null, RichTextBox textBox = null)
        {
            string outputCase = "";
            if (data == null || textboxBuilder == null || textBox == null)
            {
                outputCase = $"{nameof(BookCase)} is chosen for mobile";
                Output.WriteLine(outputCase);
            }
            else
            {
                outputCase = $"{nameof(BookCase)} is chosen for mobile";
                Output.WriteOn(outputCase, textBox, textboxBuilder);
            }
            return outputCase;
        }
    }
}
