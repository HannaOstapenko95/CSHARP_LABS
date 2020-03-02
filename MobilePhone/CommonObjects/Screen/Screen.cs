using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.CommonObjects.Screen
{
    public class Screen
    {
        public string Resolution { get; set; } //Full HD (1920X1080), HD (1280X720)..
        public double Diagonal { get; set; } //4, 5, 5.5, 6...
        public TypeOfScreens TypeOfScreen { get; set; } //IPS, Super Amoled, NFC
        public Screen()
        {

        }
        public Screen(string resolution, double diagonal, TypeOfScreens typeOfScreen)
        {
            Resolution = resolution;
            Diagonal = diagonal;
            TypeOfScreen = typeOfScreen;
        }
        public override string ToString()
        {
            return "Screen";
        }

    }
}
