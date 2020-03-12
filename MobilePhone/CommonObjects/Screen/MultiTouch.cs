using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.CommonObjects.Screen
{
    public class MultiTouch : BasicTouch
    {
        //Handle multi-touch input from user
        public MultiTouch(string resolution, double diagonal, int numberOfTouchesSimultaneously, TypeOfScreens typeOfScreen) : base(resolution, diagonal, numberOfTouchesSimultaneously, typeOfScreen)
        {
        }
        public override string ToString()
        {
            return "Multi-Touch Screen";
        }
    }
}
