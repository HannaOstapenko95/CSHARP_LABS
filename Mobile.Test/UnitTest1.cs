using System;
using Xunit;

namespace Mobile.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var repository = new FakeRepository();
            var playb = new iPhoneHeadset(repository);
            var expected = "iPhoneHeadset sound";
            
            
            Assert.Matches(expected, playb.Play());

        }
    }
}
