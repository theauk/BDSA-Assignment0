using System;
using System.IO;
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

        [Fact]
        public void Prints_yay()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            Program.PrintIsLeapYear(1996);

            // Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("yay", output);
        }

        [Fact]
        public void Prints_nay()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            Program.PrintIsLeapYear(1767);

            // Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("nay", output);
        }
    }
}
