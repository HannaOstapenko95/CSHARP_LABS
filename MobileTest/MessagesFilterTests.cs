using MessagesWinFormApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobile.MobilePhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SMSProvider;

namespace MobileTest
{
    public class MessagesFilterTests
    {
        [TestMethod]
        public void Search_By_Text()
        {
            //Arrange
            var comparer = new MessageComparer();
            frmMessageFormatting f = new frmMessageFormatting();
            DateTime date2 = new DateTime(2019, 1, 1, 4, 0, 15);
            List<Message> expectedList = new List<Message>()
            {
                new Message(Users.Volodymyr, "Thank you!", date2.AddMonths(2)),
                new Message(Users.Dmytro, "Thank you very much!", DateTime.Now.Date)
            };
            //Act
            List<Mobile.MobilePhone.Message> actualList = f.SearchByText("Thank").ToList();

            //Assert
            Console.WriteLine($"{expectedList[0].User}={actualList[0].User}");
            Console.WriteLine($"{expectedList[0].Text}={actualList[0].Text}");
            Console.WriteLine($"{expectedList[0].ReceivingTime}={actualList[0].ReceivingTime}");
            Console.WriteLine($"{expectedList[1].User}={actualList[1].User}");
            Console.WriteLine($"{expectedList[1].Text}={actualList[1].Text}");
            Console.WriteLine($"{expectedList[1].ReceivingTime}={actualList[1].ReceivingTime}");

            CollectionAssert.AreEqual(expectedList, actualList, comparer);

            //Additionally can check:
            Assert.AreEqual(expectedList[0].User, actualList[0].User);
            Assert.AreEqual(expectedList[0].Text, actualList[0].Text);
            Assert.AreEqual(expectedList[0].ReceivingTime, actualList[0].ReceivingTime);
            Assert.AreEqual(expectedList[1].User, actualList[1].User);
            Assert.AreEqual(expectedList[1].Text, actualList[1].Text);
            Assert.AreEqual(expectedList[1].ReceivingTime, actualList[1].ReceivingTime);
        }
        [TestMethod]
        public void Search_Between_Dates()
        {
            //Arrange
            var comparer = new MessageComparer();
            frmMessageFormatting f = new frmMessageFormatting();
            DateTime dateFrom = new DateTime(2009, 1, 1, 4, 0, 15);
            DateTime date1 = new DateTime(2010, 1, 1, 4, 0, 15);
            DateTime dateTo = new DateTime(2010, 2, 1, 4, 0, 15);
            List<Message> expectedList = new List<Message>()
            {
                new Message(Users.Dmytro, "Hello everybody!", date1),
                new Message(Users.Hanna, "Please, go home!", date1),
            };
            //Act
            List<Mobile.MobilePhone.Message> actualList = f.SearchByDate(dateFrom, dateTo);
            //Assert
            CollectionAssert.AreEqual(expectedList, actualList, comparer);

            Console.WriteLine($"{expectedList[0].User}={actualList[0].User}");
            Console.WriteLine($"{expectedList[0].Text}={actualList[0].Text}");
            Console.WriteLine($"{expectedList[0].ReceivingTime}={actualList[0].ReceivingTime}");
            Console.WriteLine($"{expectedList[1].User}={actualList[1].User}");
            Console.WriteLine($"{expectedList[1].Text}={actualList[1].Text}");
            Console.WriteLine($"{expectedList[1].ReceivingTime}={actualList[1].ReceivingTime}");

            //Additionally can check:
            Assert.AreEqual(expectedList[0].User, actualList[0].User);
            Assert.AreEqual(expectedList[0].Text, actualList[0].Text);
            Assert.AreEqual(expectedList[0].ReceivingTime, actualList[0].ReceivingTime);
            Assert.AreEqual(expectedList[1].User, actualList[1].User);
            Assert.AreEqual(expectedList[1].Text, actualList[1].Text);
            Assert.AreEqual(expectedList[1].ReceivingTime, actualList[1].ReceivingTime);

        }
        [TestMethod]
        public void Search_By_User()
        {
            //Arrange
            var comparer = new MessageComparer();
            frmMessageFormatting f = new frmMessageFormatting();
            DateTime date2 = new DateTime(2019, 1, 1, 4, 0, 15);
            DateTime date3 = new DateTime(2022, 1, 1, 4, 0, 15);
            List<Message> expectedList = new List<Message>()
            {
                new Message(Users.Helen, "Good night!", date3),
                new Message(Users.Helen, "It is very late..", date2)
            };
            //Act
            List<Mobile.MobilePhone.Message> actualList = f.SearchByUser("Helen");
            //Assert
            CollectionAssert.AreEqual(expectedList, actualList, comparer);

            Console.WriteLine($"{expectedList[0].User}={actualList[0].User}");
            Console.WriteLine($"{expectedList[0].Text}={actualList[0].Text}");
            Console.WriteLine($"{expectedList[0].ReceivingTime}={actualList[0].ReceivingTime}");
            Console.WriteLine($"{expectedList[1].User}={actualList[1].User}");
            Console.WriteLine($"{expectedList[1].Text}={actualList[1].Text}");
            Console.WriteLine($"{expectedList[1].ReceivingTime}={actualList[1].ReceivingTime}");
            //Additionally can check
            Assert.AreEqual(expectedList[0].User, actualList[0].User);
            Assert.AreEqual(expectedList[0].Text, actualList[0].Text);
            Assert.AreEqual(expectedList[0].ReceivingTime, actualList[0].ReceivingTime);
            Assert.AreEqual(expectedList[1].User, actualList[1].User);
            Assert.AreEqual(expectedList[1].Text, actualList[1].Text);
            Assert.AreEqual(expectedList[1].ReceivingTime, actualList[1].ReceivingTime);
        }
        [TestMethod]
        public void Check_And_Logic()
        {
            //Arrange
            var comparer = new MessageComparer();
            DateTime dateFrom = new DateTime(2020, 1, 1, 4, 0, 15);
            DateTime dateTo = new DateTime(2021, 2, 1, 4, 0, 15);
            frmMessageFormatting f = new frmMessageFormatting();
            List<Message> expectedList = new List<Message>()
            {
                new Message(Users.Dmytro, "Thank you very much!", DateTime.Now.Date)
            };
            bool andChecked = true;
            bool orChecked = false;
            //Act
            List<Mobile.MobilePhone.Message> actualList = f.CheckFileringLogic(andChecked, orChecked, "Thank", "Dmytro", dateFrom, dateTo).ToList();
            //Assert
            CollectionAssert.AreEqual(expectedList, actualList, comparer);
            Console.WriteLine($"{expectedList[0].User}={actualList[0].User}");
            Console.WriteLine($"{expectedList[0].Text}={actualList[0].Text}");
            Console.WriteLine($"{expectedList[0].ReceivingTime}={actualList[0].ReceivingTime}");
            Assert.AreEqual(expectedList[0].User, actualList[0].User);
            Assert.AreEqual(expectedList[0].Text, actualList[0].Text);
            Assert.AreEqual(expectedList[0].ReceivingTime, actualList[0].ReceivingTime);
        }
        [TestMethod]
        public void Check_OR_Logic()
        {
            //Arrange
            var comparer2 = new MessageComparer();
            DateTime dateFrom = new DateTime(2020, 1, 1, 4, 0, 15);
            DateTime dateTo = new DateTime(2021, 2, 1, 4, 0, 15);
            DateTime date1 = new DateTime(2010, 1, 1, 4, 0, 15);
            DateTime date2 = new DateTime(2019, 1, 1, 4, 0, 15);
            frmMessageFormatting f = new frmMessageFormatting();
            List<Message> expectedList = new List<Message>()
            {
                new Message(Users.Volodymyr, "Thank you!", date2.AddMonths(2)),
                new Message(Users.Dmytro, "Thank you very much!", DateTime.Now.Date),
                new Message(Users.Dmytro, "Hello everybody!", date1),
                new Message(Users.Olga, "I am working..", DateTime.Now.AddDays(2))
            };
            bool andChecked = false;
            bool orChecked = true;
            //Act
            List<Mobile.MobilePhone.Message> actualList = f.CheckFileringLogic(andChecked, orChecked, "Thank", "Dmytro", dateFrom, dateTo).ToList();
            //Assert
            CollectionAssert.AreEqual(expectedList, actualList, comparer2);

            Console.WriteLine($"{expectedList[0].User}={actualList[0].User}");
            Console.WriteLine($"{expectedList[0].Text}={actualList[0].Text}");
            Console.WriteLine($"{expectedList[0].ReceivingTime}={actualList[0].ReceivingTime}");
            Console.WriteLine($"{expectedList[1].User}={actualList[1].User}");
            Console.WriteLine($"{expectedList[1].Text}={actualList[1].Text}");
            Console.WriteLine($"{expectedList[1].ReceivingTime}={actualList[1].ReceivingTime}");
            Console.WriteLine($"{expectedList[2].User}={actualList[2].User}");
            Console.WriteLine($"{expectedList[2].Text}={actualList[2].Text}");
            Console.WriteLine($"{expectedList[2].ReceivingTime}={actualList[2].ReceivingTime}");
            Assert.AreEqual(expectedList[0].User, actualList[0].User);
            Assert.AreEqual(expectedList[0].Text, actualList[0].Text);
            Assert.AreEqual(expectedList[0].ReceivingTime, actualList[0].ReceivingTime);
            Assert.AreEqual(expectedList[1].User, actualList[1].User);
            Assert.AreEqual(expectedList[1].Text, actualList[1].Text);
            Assert.AreEqual(expectedList[1].ReceivingTime, actualList[1].ReceivingTime);
            Assert.AreEqual(expectedList[2].User, actualList[2].User);
            Assert.AreEqual(expectedList[2].Text, actualList[2].Text);
            Assert.AreEqual(expectedList[2].ReceivingTime, actualList[2].ReceivingTime);
        }
        [TestMethod]
        public void Check_ADDING_Logic()
        {
            frmMessageFormatting f = new frmMessageFormatting();
            Storage stor = new Storage();
            var x = Storage.GenerateMessagesList();
            Console.WriteLine("Before adding:" + x.Count);
            stor.SMSAdded += (messages, user, message, dateTime) => f.OnSMSAdded(messages, user, message, dateTime);
            stor.AddSMS(x, Users.Hanna, "Do not smoke!", DateTime.Now);
            Console.WriteLine("After adding:" + x.Count);
            Assert.AreEqual(13, x.Count);
        }
        [TestMethod]
        public void Check_REMOVE_Logic()
        {
            DateTime date1 = new DateTime(2010, 1, 1, 4, 0, 15);
            frmMessageFormatting f = new frmMessageFormatting();
            Storage stor = new Storage();
            var x = Storage.GenerateMessagesList();
            Console.WriteLine("Before removing:" + x.Count);
            stor.SMSRemoved += (messages, user, message, dateTime) => f.OnSMSRemoved(messages, user, message, dateTime);
            stor.RemoveSMS(x, Users.Hanna, "Please, go home!", date1);
            Console.WriteLine("After removing:" + x.Count);
            Assert.AreEqual(11, x.Count);
        }
    }
}
