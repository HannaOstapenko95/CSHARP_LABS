using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.CommonObjects.Screen
{
    public class SingleTouch : BasicTouch
    {
        //Handle single touch input from user
        public SingleTouch(string resolution, double diagonal, int numberOfTouchesSimultaneously, TypeOfScreens typeOfScreen) : base(resolution, diagonal, numberOfTouchesSimultaneously, typeOfScreen)
        {
        }
        public override string ToString()
        {
            return "Single-Touch Screen";
        }
    }
}
