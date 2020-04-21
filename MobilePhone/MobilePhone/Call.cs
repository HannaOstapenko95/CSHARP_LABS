using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.MobilePhone
{
    public enum Direction
    {
        Incoming,
        Outgoing
    }
    public class Call : IComparable<Call>, IEqualityComparer<Call>, IComparer, IEnumerable
    {
        public Contact Contact { get; set; }
        public DateTime CallTime { get; set; }
        public Direction CallDirection { get; set; }
        public List<Direction> listCallDirection { get; set; }
        public string GroupCall { get; set; }
        public Call()
        {

        }
        public Call(Contact contact, DateTime callTime, Direction callDirection)
        {
            Contact = contact;
            CallTime = callTime;
            CallDirection = callDirection;
        }
        public Call(Contact contact, Direction callDirection)
        {
            Contact = contact;
            CallDirection = callDirection;
        }

        public int CompareTo(Call other)
        {
            if (other == null)
            {
                return 1;
            }
            if (ReferenceEquals(other, this))
            {
                return 0;
            }
            if (other.GetType() != this.GetType()) throw new ArgumentException();

            return this.CallTime.CompareTo(other.CallTime);
        }

        public bool Equals(Call x, Call y)
        {
            if (x.CallDirection == y.CallDirection && x.Contact.User == y.Contact.User)
            { return true; }
            return false;
        }
        public  bool Equals(Call obj)
        {
            if (this.CallDirection == obj.CallDirection && this.Contact.User == obj.Contact.User)
            { return true; }
            return false;
        }

        public int GetHashCode(Call obj)
        {
            return obj.CallTime.GetHashCode();
        }

        public int Compare(object x, object y)
        {
            var lhs = x as Call;
            var rhs = y as Call;
            if (lhs == null || rhs == null) throw new InvalidOperationException();
            return Compare(lhs, rhs);
        }
        public int Compare(Call x, Call y)
        {
            int temp;
            if ((temp = x.CallTime.CompareTo(y.CallTime)) != 0)
            { return temp; }
            else if ((temp = x.CallDirection.CompareTo(y.CallDirection)) != 0)
            { return temp; }
            else if ((temp = x.Contact.User.CompareTo(y.Contact.User)) != 0)
            {
                return temp;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Direction val in listCallDirection)
            {
                yield return val;
            }
        }
    }
}
