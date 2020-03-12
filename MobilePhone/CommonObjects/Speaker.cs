using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class Speaker
    {
        public int NumberOfDynamics { get; } //1-2
        public int PowerDb { get; } //20-80 Db
        public Speaker(int numberOfDynamics, int powerDb)
        {
            NumberOfDynamics = numberOfDynamics;
            PowerDb = powerDb;
        }
        public override string ToString()
        {
            return "Speaker -> " + "Number of dynamics: " + NumberOfDynamics + "  Power: " + PowerDb + "Db";
        }
    }
}
