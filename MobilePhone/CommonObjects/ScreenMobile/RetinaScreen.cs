using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class RetinaScreen : ColorfulScreen
    {
        public override object Show(IScreenImage screenImage)
        {
            // here logic for Retina screen can be added   
            Console.WriteLine("Size of Retina Screen = " + screenImage.Image_size);
            Console.WriteLine("Drawing of Retina Screen = " + screenImage.Drawing);
            return new RetinaScreen();

        }
        public override object Show(IScreenImage screenImage, int brightness, string image_size, string drawing, int dpi, int numberOfColors,
            string technologyOfManufacturing)
        {
            // here logic that draws colorful image can be added
            Console.WriteLine("Size of Retina Screen = " + screenImage.Image_size);
            Console.WriteLine("Drawing of Retina Screen = " + screenImage.Drawing);
            Console.WriteLine("DPI of Retina Screen = " + dpi);
            Console.WriteLine("Number of Colors for Retina Screen = " + numberOfColors);
            Console.WriteLine("Technology of Manufacturing for Retina Screen = " + technologyOfManufacturing);
            Console.WriteLine("Brightness of Retina Screen = " + brightness);
            return new RetinaScreen();
        }
        public override string ToString()
        {
            return "Retina Screen";
        }
    }
}
