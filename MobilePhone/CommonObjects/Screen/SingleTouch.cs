using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile.CommonObjects.Screen
{
    public class SingleTouch : BasicTouch, IScreenTouch
    {
        //Handle single touch input from user
        private IOutput Output;
        public SingleTouch(string resolution, double diagonal, int numberOfTouchesSimultaneously, TypeOfScreens typeOfScreen) : base(resolution, diagonal, numberOfTouchesSimultaneously, typeOfScreen)
        {
        }

        public SingleTouch(IOutput output)
        {
            Output = output;
        }
        public string SelectScreenTouch(object data = null, StringBuilder textboxBuilder = null, RichTextBox textBox = null)
        {
            string outputScreenTouch = "";
            if (data == null || textboxBuilder == null || textBox == null)
            {
                outputScreenTouch = $"{nameof(SingleTouch)} is chosen for mobile";
                Output.WriteLine(outputScreenTouch);
            }
            else
            {
                outputScreenTouch = $"{nameof(SingleTouch)} is chosen for mobile";
                Output.WriteOn(outputScreenTouch, textBox, textboxBuilder);
            }
            return outputScreenTouch;
        }
        public override string ToString()
        {
            return "Single-Touch Screen";
        }
    }
}
