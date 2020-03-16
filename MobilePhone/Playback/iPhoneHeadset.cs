using System.Text;
using System.Windows.Forms;

namespace Mobile
{
    public class iPhoneHeadset : IPlayback
    {
        private IOutput Output;


        public iPhoneHeadset(IOutput output)
        {
            Output = output;
        }


        public string Play(object data = null, StringBuilder textboxBuilder = null, RichTextBox textBox = null)
        {
            string outpstring= "";
            if (data == null || textboxBuilder == null || textBox == null)
            {
                outpstring = $"{nameof(iPhoneHeadset)} sound";
                Output.WriteLine(outpstring);
            }
            else
            {
                outpstring = $"{nameof(iPhoneHeadset)} sound";
                Output.WriteOn(outpstring, textBox, textboxBuilder);
            }
            return outpstring;
        }
    }
}
