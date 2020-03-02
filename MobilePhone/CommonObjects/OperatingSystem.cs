using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class OperatingSystem
    {
        public OperatingSystems TypeOfOS { get; set; } //Android, IOS, MeeGo..
        public override string ToString()
        {
            return "OS";
        }
    }
}
