using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.CommonObjects.Memory
{
    public class RAM : MemoryBase
    {
        public RAM(int sizeOfMemory) : base(sizeOfMemory)
        {
        }

        public override string ToString()
        {
            return "RAM";
        }
    }
}
