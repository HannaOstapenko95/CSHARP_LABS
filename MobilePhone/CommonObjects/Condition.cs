using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.CommonObjects
{
    public class Condition
    {
        public TypeOfConditions TypeOfCondition { get; set; } //new or used
        public override string ToString()
        {
            return "Condition";
        }
    }
}
