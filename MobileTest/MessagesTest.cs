using System;
using MessagesWinFormApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobile;
using Mobile.Case;
using Mobile.Charger;
using Mobile.Test;
using static SMSProvider;

namespace MobileTest
{
    [TestClass]
    public class MessagesTests
    {
        [TestMethod]
        public void Check_None_Format()
        {
            //Arrange
            SMSProvider sms = new SMSProvider();
            Form1 form = new Form1();
            var expected = $"[{DateTime.Now}] {"Message received\r\n"}";

            //Act
            var actual = form.OnSMSReceived("Message received");
            //Assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_OnUpperCase()
        {
            //Arrange
            SMSProvider sms = new SMSProvider();
            Form1 form = new Form1();
            var expected = $"[{DateTime.Now}] {"MESSAGE RECEIVED \n"}";

            //Act
            var actual = form.OnUpperCase("Message received");

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_OnLowerCase()
        {
            //Arrange
            SMSProvider sms = new SMSProvider();
            Form1 form = new Form1();
            var expected = $"[{DateTime.Now}] {"message received \n"}";

            //Act
            var actual = form.OnLowerCase("Message received");

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_Date_At_the_End_format()
        {
            //Arrange
            SMSProvider sms = new SMSProvider();
            Form1 form = new Form1();
            var expected = $"{"Message received"} [{DateTime.Now}] \n";

            //Act
            var actual = form.OnSMSDateEnd("Message received");

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_EventRaised_When_message_generated()
        {
            //Arrange
            SMSProvider sms = new SMSProvider();
            Form1 form = new Form1();
            string smsMessage = "Message received";
            sms.SMSReceived += (message) => form.OnSMSReceived(message);

            //Act
            sms.DoWork(smsMessage);
            var actual = sms.RaiseSMSReceivedEvent(smsMessage);

            //Assert
            Assert.IsTrue(actual);
        }
    }
}
