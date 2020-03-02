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
        public SingleTouch(string resolution, double diagonal, TypeOfScreens typeOfScreen) : base(resolution, diagonal, typeOfScreen)
        {
        }
        public override string ToString()
        {
            return "Single-Touch Screen";
        }
    }
}
