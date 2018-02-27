using System;
using ConsoleApp1;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.NotNull(new Greeting().SayHello());
        }
    }
}
