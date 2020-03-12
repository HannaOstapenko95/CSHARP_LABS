﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public interface IScreenImage
    {
          string Image_size { get;  } //1280X920
          string Drawing { get; set; }
         int Dpi { get; }
         int NumberOfColors { get;  }
         string TechnologyOfManufacturing { get;}
    }
}
