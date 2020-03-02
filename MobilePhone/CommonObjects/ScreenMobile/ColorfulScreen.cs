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
        public override object Show(IScreenImage screenImage, int brightness, string image_size, string drawing)
        {
            // here logic that draws colorful image can be added
            Console.WriteLine("Size of Colorful Screen = " + screenImage.Image_size);
            Console.WriteLine("Drawing of Colorful Screen = " + screenImage.Drawing);
            Console.WriteLine("Brightness of Colorful Screen = " + brightness);
            return new ColorfulScreen();
        }
        public override string ToString()
        {
            return "Colorful Screen";
        }


    }
}
