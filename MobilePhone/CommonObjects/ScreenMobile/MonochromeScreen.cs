﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class MonochromeScreen : ScreenBase
    {
        public override object Show(IScreenImage screenImage)
        {
            //here logic that draws monochrome image can be added
            Console.WriteLine("Size of Monochrome Screen = " + screenImage.Image_size);
            Console.WriteLine("Drawing of Monochrome Screen = " + screenImage.Drawing);
            return new MonochromeScreen();
        }
        public override object Show(IScreenImage screenImage, int brightness, string image_size, string drawing, int dpi, int numberOfColors,
            string technologyOfManufacturing)
        {
            // here logic that draws colorful image can be added
            Console.WriteLine("Size of Monochrome Screen = " + screenImage.Image_size);
            Console.WriteLine("Drawing of Monochrome Screen = " + screenImage.Drawing);
            Console.WriteLine("DPI of Monochrome Screen = " + dpi);
            Console.WriteLine("Number of Colors for Monochrome Screen = " + numberOfColors);
            Console.WriteLine("Technology of Manufacturing for Monochrome Screen = " + technologyOfManufacturing);
            Console.WriteLine("Brightness of Monochrome Screen = " + brightness);
            return new MonochromeScreen();
        }
        public override string ToString()
        {
            return "Monochrome Screen";
        }


    }
}
