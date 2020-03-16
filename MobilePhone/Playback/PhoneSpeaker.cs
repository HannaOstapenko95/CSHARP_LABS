using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile
{
    public class PhoneSpeaker : IPlayback
    {
        private IOutput Output;
        public PhoneSpeaker(IOutput output)
        {
            Output = output;
        }
        public string Play(object data = null, StringBuilder textboxBuilder = null, RichTextBox textBox = null)
        {
            string outpstring = "";
            if (data == null || textboxBuilder == null || textBox == null)
            {
                outpstring = $"{nameof(PhoneSpeaker)} sound";
                Output.WriteLine(outpstring);
            }
            else
            {
                outpstring = $"{nameof(PhoneSpeaker)} sound";
                Output.WriteOn(outpstring, textBox, textboxBuilder);
            }
            return outpstring;
        }
    }
}
