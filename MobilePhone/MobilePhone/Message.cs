using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.MobilePhone
{
    public enum Users
    {
        All,
        Hanna,
        Dmytro,
        Helen,
        Olga,
        Volodymyr

    }
    public class Message
    {
                  
        public Users User { get; set; }
        public string Text { get; set; }
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public DateTime ReceivingTime { get; set; }
        public Message(Users user, string text, DateTime time)
        {
            User = user;
            Text = text;
            ReceivingTime = time;
        }
        

    }
}
