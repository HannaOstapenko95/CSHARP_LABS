using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.CommonObjects
{

    public class MobileType
    {
        public MobileTypeConcrete TypeOfMobile { get; set; } //smartphone or push-button phones
        public override string ToString()
        {
            return "Type of Mobile";
        }
    }
}
