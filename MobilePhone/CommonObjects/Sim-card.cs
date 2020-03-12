using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class Sim_card
    {
        //public int NumberOfSimCards { get; set; } //1-3
        public string OperatorPhone { get; set; } //Life, Vodafone, Kyivstar
        public string FormFactor { get; set; } //Micro, Nano, Standart
        public Sim_card(string operatorPhone, string formFactor)
        {
            OperatorPhone = operatorPhone;
            FormFactor = formFactor;
        }
        public override string ToString()
        {
            return "Sim_Cards";
        }
    }
}
