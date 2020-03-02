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
        public MultiTouch(string resolution, double diagonal, TypeOfScreens typeOfScreen) : base(resolution, diagonal, typeOfScreen)
        {
        }
        public override string ToString()
        {
            return "Multi-Touch Screen";
        }
    }
}
