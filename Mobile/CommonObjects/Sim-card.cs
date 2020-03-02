using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class Sim_card
    {
        public int NumberOfSimCards { get; set; } //1-3
        public Sim_card()
        {

        }
        public Sim_card(int numberOfSimCards)
        {
            NumberOfSimCards = numberOfSimCards;
        }
        public override string ToString()
        {
            return "Sim_Cards";
        }
    }
}
