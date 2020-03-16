using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobile;
using Mobile.Case;
using Mobile.Charger;
using Mobile.Test;

namespace MobileTest
{
    [TestClass]
    public class ChargerTests
    {
        [TestMethod]
        public void Charge_Return_Charger_is_chosen()
        {
            //Arrange
            var repository = new FakeRepository();
            var selectCharger = new Charger(repository);
            var expected = "Charger is chosen for charging";
            //Act
            var actual = selectCharger.Charge();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Charge_Return_PowerBank_is_chosen()
        {
            //Arrange
            var repository = new FakeRepository();
            var selectCharger = new PowerBank(repository);
            var expected = "PowerBank is chosen for charging";
            //Act
            var actual = selectCharger.Charge();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
