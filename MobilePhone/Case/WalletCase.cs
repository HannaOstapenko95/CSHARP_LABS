using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile.Case
{
    public class WalletCase : ICase
    {
        private IOutput Output;
        public WalletCase(IOutput output)
        {
            Output = output;
        }
        public string SelectCase(object data = null, StringBuilder textboxBuilder = null, RichTextBox textBox = null)
        {
            string outputCase = "";
            if (data == null || textboxBuilder == null || textBox == null)
            {
                outputCase = $"{nameof(WalletCase)} is chosen for mobile";
                Output.WriteLine(outputCase);
            }
            else
            {
                outputCase = $"{nameof(WalletCase)} is chosen for mobile";
                Output.WriteOn(outputCase, textBox, textboxBuilder);
            }
            return outputCase;
        }
    }
}
