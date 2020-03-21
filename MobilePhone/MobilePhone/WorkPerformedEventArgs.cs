using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.MobilePhone
{
    public class WorkPerformedEventArgs : EventArgs
    {
        public WorkPerformedEventArgs(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}
