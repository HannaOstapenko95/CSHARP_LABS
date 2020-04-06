using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.MobilePhone
{
    public  class Storage
    {
        public delegate List<Message> SMSAddedDelegate(List<Message> messages, Users user, string message, DateTime dateTime);
        public event SMSAddedDelegate SMSAdded;
        public delegate List<Message> SMSRemovedDelegate(List<Message> messages, Users user, string message, DateTime dateTime);
        public event SMSRemovedDelegate SMSRemoved;

        public bool RaiseSMSAddedEvent(List<Message> messages, Users user, string message, DateTime dateTime)
        {
            var handler = SMSAdded;
            if (handler != null)
            {
                handler(messages, user,  message, dateTime);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RaiseSMSRemovedEvent(List<Message> messages, Users user, string message, DateTime dateTime)
        {
            var handler = SMSRemoved;
            if (handler != null)
            {
                handler(messages, user, message, dateTime);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AddSMS(List<Message> messages, Users user, string message, DateTime dateTime)
        {
            RaiseSMSAddedEvent(messages, user, message, dateTime);
            return;
        }
        public void RemoveSMS(List<Message> messages, Users user, string message, DateTime dateTime)
        {
            RaiseSMSRemovedEvent(messages, user, message, dateTime);
            return;
        }
        public Storage()
        {

        }
        public static List<Message> GenerateMessagesList()
        {
            DateTime date1 = new DateTime(2010, 1, 1, 4, 0, 15);
            DateTime date2 = new DateTime(2019, 1, 1, 4, 0, 15);
            DateTime date3 = new DateTime(2022, 1, 1, 4, 0, 15);
            List<Message> mess = new List<Message>()
            {
                new Message(Users.Dmytro, "Hello everybody!", date1),
                new Message(Users.Hanna, "Good morning!", date2),
                new Message(Users.Helen, "Good night!", date3),
                new Message(Users.Olga, "Very good!", date3.AddDays(2)),
                new Message(Users.Olga, "I am working..", DateTime.Now.AddDays(2)),
                new Message(Users.Volodymyr, "Thank you!", date2.AddMonths(2)),
                new Message(Users.Dmytro, "Thank you very much!", DateTime.Now.Date),
                new Message(Users.Hanna, "Please, go home!", date1),
                new Message(Users.Hanna, "It is very bad..", date2),
                new Message(Users.Helen, "It is very late..", date2),
                new Message(Users.Olga, "I like it.", date3.AddDays(25)),
                new Message(Users.Volodymyr, "Congratulations!!", date2.AddMonths(5))
            };
            return mess;
        }
        public  List<Message> AddMessage(List<Message> messages, Users user, string text, DateTime dateTime)
        {
            messages.Add(new Message(user, text, dateTime)
            { User = user, Text = text, ReceivingTime = dateTime });
            return messages;
        }
        public  List<Message> RemoveMessage(List<Message> messages, Users user, string text, DateTime dateTime)
        {
            var forRemove = messages.Where(m => m.User == user && m.Text == text && m.ReceivingTime == dateTime);
            messages.Remove(forRemove.FirstOrDefault());
            return messages;
        }
    }
}
