using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class Battery
    {
        public int Size { get; set; } 
        public int Volume { get; set; } //мАч
        public Battery()
        {

        }
        public Battery(int size, int volume)
        {
            this.Size = size;
            this.Volume = volume;
        }
        public override string ToString()
        {
            return "Battery -> "+"Size: " + Size + "  Volume: " + Volume + "mAh";
        }
    }
}
