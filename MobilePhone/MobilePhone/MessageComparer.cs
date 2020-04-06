using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.MobilePhone
{
    public class MessageComparer : IEqualityComparer<Message>, IComparer, IComparer<Message>
    {
        public bool Equals(Message x, Message y)
        {
            if (x.User == y.User && x.Text == y.Text && x.ReceivingTime == y.ReceivingTime)
            { return true; }
            return false;
        }
        public int GetHashCode(Message obj)
        {
            return obj.User.GetHashCode();
        }
        public int Compare(Message x, Message y)
        {
            int temp;
            if ((temp = x.User.CompareTo(y.User)) != 0)
            { return temp; }
            else if ((temp = x.Text.CompareTo(y.Text)) != 0)
            { return temp; }
            else if ((temp = x.ReceivingTime.CompareTo(y.ReceivingTime)) != 0)
            {
                return temp;
            }
            else
            {
                return 0;
            }
                
        }

        public int Compare(object x, object y)
        {
            var lhs = x as Message;
            var rhs = y as Message;
            if (lhs == null || rhs == null) throw new InvalidOperationException();
            return Compare(lhs, rhs);
        }
    }
}
