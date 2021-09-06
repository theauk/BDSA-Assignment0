using System;
using Xunit;

namespace LeapYear.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Divisible_by_Four()
        {
            Assert.True(Program.IsLeapYear(2004));
        }

        [Fact]
        public void Not_Divisible_by_Four()
        {
            Assert.False(Program.IsLeapYear(1973));
        }

        [Fact]
        public void Centurial_Leap_Year()
        {
            Assert.True(Program.IsLeapYear(2000));
        }

        [Fact]
        public void Not_Centurial_Leap_Year()
        {
            Assert.False(Program.IsLeapYear(1931));
        }
    }
}
