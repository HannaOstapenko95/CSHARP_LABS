using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Mobile;

namespace Mobile.Test
{
    public class FakeRepository : IOutput
    {
        private IOutput Output;
        public FakeRepository()
        {

        }
        public FakeRepository(IOutput output)
        {
            Output = output;
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

        public void WriteOn(string text = null, RichTextBox textBox = null, StringBuilder textboxBuilder = null)
        {
            throw new NotImplementedException();
        }
    }
}
