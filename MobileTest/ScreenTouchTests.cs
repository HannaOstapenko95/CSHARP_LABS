using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobile;
using Mobile.Case;
using Mobile.CommonObjects.Screen;
using Mobile.Test;

namespace MobileTest
{
    [TestClass]
    public class ScreenTouchTests
    {
        [TestMethod]
        public void SelectScreenTouch_Return_MultiTouch_chosen()
        {
            //Arrange
            var repository = new FakeRepository();
            var selectScreenTouch = new MultiTouch(repository);
            var expected = "MultiTouch is chosen for mobile";
            //Act
            var actual = selectScreenTouch.SelectScreenTouch();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SelectScreenTouch_Return_SingleTouch_chosen()
        {
            //Arrange
            var repository = new FakeRepository();
            var selectScreenTouch = new SingleTouch(repository);
            var expected = "SingleTouch is chosen for mobile";
            //Act
            var actual = selectScreenTouch.SelectScreenTouch();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
