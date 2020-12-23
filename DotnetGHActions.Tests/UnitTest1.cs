using System;
using Xunit;

namespace DotnetGHActions.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void Test2()
        {

        }

        [Fact]
        public void Test3()
        {

        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void Test4(int x)
        {
            x.GetType();
        }
    }
}
