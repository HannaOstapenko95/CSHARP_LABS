using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class OLEDScreen : ScreenBase
    {
        public OLEDScreen()
        {

        }
        public OLEDScreen(string image_size, string drawing)
        {
            Image_size = image_size;
            Drawing = drawing;
        }
        public string Image_size { get; set; } //1280X920
        public string Drawing { get; set; }

        public override object Show(IScreenImage screenImage)
        {
            // here logic for OLED screen can be added
            Console.WriteLine("Size of OLED Screen = " + screenImage.Image_size);
            Console.WriteLine("Drawing of OLED Screen = " + screenImage.Drawing);
            return new OLEDScreen();
        }
        public override object Show(IScreenImage screenImage, int brightness, string image_size, string drawing, int dpi, int numberOfColors,
            string technologyOfManufacturing)
        {
            // here logic that draws colorful image can be added
            Console.WriteLine("Size of OLED Screen = " + image_size);
            Console.WriteLine("Drawing of OLED Screen = " + drawing);
            Console.WriteLine("DPI of Colorful Screen = " + dpi);
            Console.WriteLine("Number of Colors for Colorful Screen = " + numberOfColors);
            Console.WriteLine("Technology of Manufacturing for Colorful Screen = " + technologyOfManufacturing);
            Console.WriteLine("Brightness of OLED Screen = " + brightness);
            OLEDScreen vOLEDScreen = new OLEDScreen();
            return vOLEDScreen;
        }
        public override string ToString()
        {
            return "OLED Screen";
        }
    }
}
