using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.CommonObjects
{
    public class MemoryCard
    {
        public int Size { get; set; } //2, 16, 32, 64, 128 Gb
        public MemoryCard(int size)
        {
            Size = size;
        }
        public override string ToString()
        {
            return "Memory Card";
        }
    }
}
