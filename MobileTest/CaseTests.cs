using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobile;
using Mobile.Case;
using Mobile.Test;

namespace MobileTest
{
    [TestClass]
    public class CaseTests
    {
        [TestMethod]
        public void SelectCase_Return_BookCase_chosen()
        {
            //Arrange
            var repository = new FakeRepository();
            var selectCase = new BookCase(repository);
            var expected = "BookCase is chosen for mobile";
            //Act
            var actual = selectCase.SelectCase();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SelectCase_Return_FolioCase_chosen()
        {
            //Arrange
            var repository = new FakeRepository();
            var selectCase = new FolioCase(repository);
            var expected = "FolioCase is chosen for mobile";
            //Act
            var actual = selectCase.SelectCase();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SelectCase_Return_SlimCase_chosen()
        {
            //Arrange
            var repository = new FakeRepository();
            var selectCase = new SlimCase(repository);
            var expected = "SlimCase is chosen for mobile";
            //Act
            var actual = selectCase.SelectCase();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SelectCase_Return_ToughCase_chosen()
        {
            //Arrange
            var repository = new FakeRepository();
            var selectCase = new ToughCase(repository);
            var expected = "ToughCase is chosen for mobile";
            //Act
            var actual = selectCase.SelectCase();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SelectCase_Return_WalletCase_chosen()
        {
            //Arrange
            var repository = new FakeRepository();
            var selectCase = new WalletCase(repository);
            var expected = "WalletCase is chosen for mobile";
            //Act
            var actual = selectCase.SelectCase();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
