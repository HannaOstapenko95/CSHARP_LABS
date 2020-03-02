using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class Dynamic
    {
        public int NumberOfDynamics { get; set; } //1-2
        public int PowerDb { get; set; } //20-80 Db
        public Dynamic()
        {

        }
        public Dynamic(int numberOfDynamics, int powerDb)
        {
            NumberOfDynamics = numberOfDynamics;
            PowerDb = powerDb;
        }
        public override string ToString()
        {
            return "Dynamic -> " + "Number of dynamics: " + NumberOfDynamics + "  Power: " + PowerDb + "Db";
        }
    }
}
