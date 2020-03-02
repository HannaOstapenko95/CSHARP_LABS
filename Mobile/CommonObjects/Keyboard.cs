using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class Keyboard
    {
        public char[] Figures { get; set; } //!@$...
        public char[] Letters { get; set; } //ABCD...
        public Keyboard()
        {

        }
        public Keyboard(char[] figures, char[] letters)
        {
            Figures = figures;
            Letters = letters;
        }
        public override string ToString()
        {
            return "Keyboard";
        }
    }
}
