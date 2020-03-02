using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.CommonObjects.Memory
{
    public class BuildInMemory : MemoryBase
    {
        public BuildInMemory(int sizeOfMemory) : base(sizeOfMemory)
        {
        }
        public override string ToString()
        {
            return "Build-In Memory";
        }
    }
}
