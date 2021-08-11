using System;
using Xunit;
using CircleDiff;

namespace Testing
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(FindDiff.diff(5) == 50);
        }

        [Fact]
        public void Test2()
        {
            Assert.True(FindDiff.diff(6) == 72);
        }

        [Fact]
        public void Test3()
        {
            Assert.True(FindDiff.diff(7) == 98);
        }
    }
}
