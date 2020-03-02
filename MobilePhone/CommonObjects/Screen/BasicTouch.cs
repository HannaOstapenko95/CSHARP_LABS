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
        public BasicTouch(string resolution, double diagonal, TypeOfScreens typeOfScreen) : base(resolution, diagonal, typeOfScreen)
        {
        }

        public override string ToString()
        {
            return "Basic Touch Screen";
        }
    }
}
