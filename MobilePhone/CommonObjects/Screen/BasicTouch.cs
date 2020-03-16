using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile.CommonObjects.Screen
{
    public class BasicTouch : Screenn, IScreenTouch
    {
        //Basic touch functionality
        private IOutput Output;
        public BasicTouch()
        {
            
        }
        public BasicTouch(string resolution, double diagonal, int numberOfTouchesSimultaneously, TypeOfScreens typeOfScreen) : base(resolution, diagonal, numberOfTouchesSimultaneously, typeOfScreen)
        {
        }
        public BasicTouch(IOutput output)
        {
            Output = output;
        }
        public virtual string SelectScreenTouch(object data = null, StringBuilder textboxBuilder = null, RichTextBox textBox = null)
        {
            string outputScreenTouch = "";
            if (data == null || textboxBuilder == null || textBox == null)
            {
                outputScreenTouch = $"{nameof(BasicTouch)} is chosen for mobile";
                Output.WriteLine(outputScreenTouch);
            }
            else
            {
                outputScreenTouch = $"{nameof(BasicTouch)} is chosen for mobile";
                Output.WriteOn(outputScreenTouch, textBox, textboxBuilder);
            }
            return outputScreenTouch;
        }
        
        public override string ToString()
        {
            return "Basic Touch Screen";
        }
    }
}
