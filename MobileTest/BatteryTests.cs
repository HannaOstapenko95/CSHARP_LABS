using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobile;
using Mobile.Case;
using Mobile.Test;
using MessagesWinFormApp;
using System.Threading;
using System.Threading.Tasks;

namespace MobileTest
{
    [TestClass]
    public class BatteryTests
    {
        [TestMethod]
        public  void Verify_Charge_Between()
        {
            //Arrange
            Battery btr = new Battery();
            frmMessageFormatting f = new frmMessageFormatting();
            CancellationTokenSource cancelTokenSrc;
            CancellationToken token2;
            //Act
            var actual =  f.ChargeAsync(token2);
            //Assert
            Assert.IsTrue(actual.Result > 0 && actual.Result < 100);
        }
        [TestMethod]
        public void Verify_Battery_Charging_Via_Threads()
        {
            //Arrange
            Battery btr = new Battery();
            frmMessageFormatting f = new frmMessageFormatting();
            btr.Charge = 0;
            CancellationTokenSource cancelTokenSrc;
            CancellationToken token2;
            //Act
            f.ChargeAsync(token2);
            bool expected = btr.Charge > 0;
            //Assert
            Assert.IsTrue(expected);
        }
        [TestMethod]
        public void Verify_Battery_DisCharging_Via_Threads()
        {
            //Arrange
            Battery btr = new Battery();
            frmMessageFormatting f = new frmMessageFormatting();
            btr.Charge = 100;
            //Act
            f.DisCharge();
            bool expected = btr.Charge < 100;
            //Assert
            Assert.IsTrue(expected);
        }
        [TestMethod]
        public void Verify_Battery_Charging_Via_Tasks()
        {
            //Arrange
            Battery btr = new Battery();
            frmMessageFormatting f = new frmMessageFormatting();
            btr.Charge = 0;
            Task actual = new Task(f.ChargeTask);
            //Act
            actual.Start();
            bool expected = btr.Charge > 0;
            //Assert
            Assert.IsTrue(expected);
        }
        [TestMethod]
        public void Verify_Battery_DisCharging_Via_Tasks()
        {
            //Arrange
            Battery btr = new Battery();
            frmMessageFormatting f = new frmMessageFormatting();
            btr.Charge = 100;
            Task actual = new Task(f.DisChargeTask);
            //Act
            actual.Start();
            bool expected = btr.Charge < 100;
            //Assert
            Assert.IsTrue(expected);
        }

    }
}
