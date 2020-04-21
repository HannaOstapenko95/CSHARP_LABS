using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.MobilePhone
{
    public class Contact : IEnumerable
    {
        public Users User { get; set; }
        public List<SimCorpMobile> ListMobiles { get; set; }
        public Contact(Users user, List<SimCorpMobile> listMobiles)
        {
            User = user;
            ListMobiles = listMobiles;
        }
        public List<Users> listUsers { get; set; }
        public IEnumerator GetEnumerator()
        {
            foreach (Users val in listUsers)
            {
                yield return val;
            }
        }
    }
}
