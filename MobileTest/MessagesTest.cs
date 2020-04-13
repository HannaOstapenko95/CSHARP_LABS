using System;
using System.Collections.Generic;
using System.Linq;
using MessagesWinFormApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobile;
using Mobile.Case;
using Mobile.Charger;
using Mobile.MobilePhone;
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
            frmMessageFormatting form = new frmMessageFormatting();
            var expected = $"[{DateTime.Now}] {"Message received\r\n"}";

            //Act
            var actual = form.OnSMSReceived("Message received");

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_OnUpperCase()
        {
            //Arrange
            SMSProvider sms = new SMSProvider();
            frmMessageFormatting form = new frmMessageFormatting();
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
            frmMessageFormatting form = new frmMessageFormatting();
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
            frmMessageFormatting form = new frmMessageFormatting();
            DateTime dateConstant = new DateTime(2010, 1, 1, 4, 0, 15);
            var expected = $"{"Message received"} {dateConstant}";

            //Act
            string actual = form.OnSMSDateEnd("Message received");
            //Replace date received from OnSMSDateEnd on constant date 
            string actualWithReplacedDate = actual.Replace(actual.Substring(17), dateConstant.ToString());

            //Assert
            Assert.AreEqual(expected, actualWithReplacedDate);
        }
        [TestMethod]
        public void Check_EventRaised_When_message_generated()
        {
            ////Arrange
            //SMSProvider sms = new SMSProvider();
            //frmMessageFormatting form = new frmMessageFormatting();
            //string smsMessage = "Message received";
            //sms.SMSReceived += (message) => form.OnSMSReceived(message);

            ////Act
            //sms.DoWork(smsMessage);
            //var actual = sms.RaiseSMSReceivedEvent(smsMessage);

            //Assert.IsTrue(actual);
        }

       
    }
}
