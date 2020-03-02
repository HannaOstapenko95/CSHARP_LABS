using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.CommonObjects
{
    public class Manufacturer
    {
        public ManufacturerBrands ManufacturerBrand { get; set; } //Apple, Samsung, LG, Asus..
        public string CountryOfManufacturer { get; set; } //China, USA, Ukraine, Great Britan
        public override string ToString()
        {
            return "Manufacturer";
        }
    }
}
