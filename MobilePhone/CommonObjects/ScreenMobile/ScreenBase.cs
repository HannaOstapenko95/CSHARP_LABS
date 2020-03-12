using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public abstract class ScreenBase : IScreenImage
    {
        public string Image_size { get;  } //1280X920
        public string Drawing { get; set; }
        public int Dpi { get;  }
        public int NumberOfColors { get; }
        public string TechnologyOfManufacturing { get;  }
        public abstract object Show(IScreenImage screenImage);
        public abstract object Show(IScreenImage screenImage, int brightness, string image_size, string drawing, int dpi, int numberOfColors,
            string technologyOfManufacturing);
    }
}
