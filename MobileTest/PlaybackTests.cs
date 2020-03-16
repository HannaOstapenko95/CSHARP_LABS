using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobile;
using Mobile.Test;

namespace MobileTest
{
    [TestClass]
    public class PlaybackTests
    {
        [TestMethod]
        public void Play_Return_iPhoneHeadset_sound()
        {
            //Arrange
            var repository = new FakeRepository();
            var playb = new iPhoneHeadset(repository);
            var expected = "iPhoneHeadset sound";
            //Act
            var actual = playb.Play();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Play_Return_SamsungHeadset_sound()
        {
            var repository = new FakeRepository();
            var playb = new SamsungHeadset(repository);
            var expected = "SamsungHeadset sound";
            var actual = playb.Play();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Play_Return_PhoneSpeaker_sound()
        {
            var repository = new FakeRepository();
            var playb = new PhoneSpeaker(repository);
            var expected = "PhoneSpeaker sound";
            var actual = playb.Play();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Play_Return_UnofficialPhoneHeadset_sound()
        {
            var repository = new FakeRepository();
            var playb = new UnofficialPhoneHeadset(repository);
            var expected = "UnofficialPhoneHeadset sound";
            var actual = playb.Play();
            Assert.AreEqual(expected, actual);
        }
    }
}
