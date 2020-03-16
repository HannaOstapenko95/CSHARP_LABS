using System.Text;
using System.Windows.Forms;

namespace Mobile
{
    public class SamsungHeadset : IPlayback
    {
        private IOutput Output;
        public SamsungHeadset(IOutput output)
        {
            Output = output;
        }
        public string Play(object data = null, StringBuilder textboxBuilder = null, RichTextBox textBox = null)
        {
            string outpstring = "";
            if (data == null || textboxBuilder == null || textBox == null)
            {
                outpstring = $"{nameof(SamsungHeadset)} sound";
                Output.WriteLine(outpstring);
            }
            else
            {
                outpstring = $"{nameof(SamsungHeadset)} sound";
                Output.WriteOn(outpstring, textBox, textboxBuilder);
            }
            return outpstring;
        }
    }
}
