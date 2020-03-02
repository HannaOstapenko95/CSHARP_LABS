using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.CommonObjects.Memory
{
    public class MemoryBase
    {
        public int SizeOfMemory { get; set; } //4-128 Gb
        public MemoryBase()
        {

        }
        public MemoryBase(int sizeOfMemory)
        {
            SizeOfMemory = sizeOfMemory;
        }
        public override string ToString()
        {
            return "Memory";
        }
    }
}
