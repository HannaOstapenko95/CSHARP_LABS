using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class ColorfulScreen : ScreenBase
    {
        public override object Show(IScreenImage screenImage)
        {
            // here logic that draws colorful image can be added
            Console.WriteLine("Size of Colorful Screen = " + screenImage.Image_size);
            Console.WriteLine("Drawing of Colorful Screen = " + screenImage.Drawing);
            return new ColorfulScreen();
        }
        public override object Show(IScreenImage screenImage, int brightness, string image_size, string drawing, int dpi, int numberOfColors,
            string technologyOfManufacturing)
        {
            // here logic that draws colorful image can be added
            Console.WriteLine("Size of Colorful Screen = " + screenImage.Image_size);
            Console.WriteLine("Drawing of Colorful Screen = " + screenImage.Drawing);
            Console.WriteLine("DPI of Colorful Screen = " + dpi);
            Console.WriteLine("Number of Colors for Colorful Screen = " + numberOfColors);
            Console.WriteLine("Technology of Manufacturing for Colorful Screen = " + technologyOfManufacturing);
            Console.WriteLine("Brightness of Colorful Screen = " + brightness);
            return new ColorfulScreen();
        }
        public override string ToString()
        {
            return "Colorful Screen";
        }


    }
}
