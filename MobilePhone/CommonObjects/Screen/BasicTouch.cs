using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.CommonObjects.Screen
{
    public class BasicTouch : Screen
    {
        //Basic touch functionality
        public BasicTouch(string resolution, double diagonal, int numberOfTouchesSimultaneously, TypeOfScreens typeOfScreen) : base(resolution, diagonal, numberOfTouchesSimultaneously, typeOfScreen)
        {
        }

        public override string ToString()
        {
            return "Basic Touch Screen";
        }
    }
}
