using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile.Charger
{
    public class Charger : ICharger
    {
        private IOutput Output;
        public Charger(IOutput output)
        {
            Output = output;
        }
        public string Charge(object data = null, StringBuilder textboxBuilder = null, RichTextBox textBox = null)
        {
            string outputCharge = "";
            if (data == null || textboxBuilder == null || textBox == null)
            {
                outputCharge = $"{nameof(Charger)} is chosen for charging";
                Output.WriteLine(outputCharge);
            }
            else
            {
                outputCharge = $"{nameof(Charger)} is chosen for charging";
                Output.WriteOn(outputCharge, textBox, textboxBuilder);
            }
            return outputCharge;
        }
    }
}
