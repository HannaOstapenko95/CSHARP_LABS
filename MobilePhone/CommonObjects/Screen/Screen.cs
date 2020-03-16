using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.CommonObjects.Screen
{
    public class Screenn
    {
        public string Resolution { get;} //Full HD (1920X1080), HD (1280X720)..
        public double Diagonal { get; } //4, 5, 5.5, 6...
        public int NumberOfTouchesSimultaneously { get; }
        public TypeOfScreens TypeOfScreen { get; } //IPS, Super Amoled
        public Screenn()
        {

        }
        public Screenn(string resolution, double diagonal, int numberOfTouchesSimultaneously, TypeOfScreens typeOfScreen)
        {
            Resolution = resolution;
            Diagonal = diagonal;
            TypeOfScreen = typeOfScreen;
            NumberOfTouchesSimultaneously = numberOfTouchesSimultaneously;
        }
        public override string ToString()
        {
            return "Screen";
        }

    }
}
