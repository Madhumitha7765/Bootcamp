using Xunit;
using StringCalculatorLib;

namespace StringCalculatorLib.Test
{
    public class InvalidParameterException : Exception
    {
        public InvalidParameterException(string message) : base(message) { }
    }

    public class StringCalculatorAddMethodTestSuite
    {
        [Fact]
        public void GivenEmptyString_ReturnsZero()
        {
            string input = "";
            int expected = 0;

            int actual = StringCalculator.Add(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenSingleZero_ReturnsZero()
        {
            string input = "0";
            int expected = 0;

            int actual = StringCalculator.Add(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenTwoNumbers_ReturnsSum()
        {
            string input = "1,2";
            int expected = 3;

            int actual = StringCalculator.Add(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenNegativeNumber_ThrowsException()
        {
            string input = "-1,2";

            Assert.Throws<ArgumentException>(() => StringCalculator.Add(input));
        }


        [Fact]
        public void GivenNewLineDelimiter_ReturnsSum()
        {
            string input = "1\n2,3";
            int expected = 6;

            int actual = StringCalculator.Add(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenNumberGreaterThan1000_IgnoresAndReturnsSum()
        {
            string input = "1,1001";
            int expected = 1;

            int actual = StringCalculator.Add(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenCustomDelimiter_ReturnsSum()
        {
            string input = "//;\n1;2";
            int expected = 3;

            int actual = StringCalculator.Add(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenMultipleCharacterDelimiter_ReturnsSum()
        {
            string input = "//[***]\n1***2***3";
            int expected = 6;

            int actual = StringCalculator.Add(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenMultipleDelimiters_ReturnsSum()
        {
            string input = "//[*][%]\n1*2%3";
            int expected = 6;

            int actual = StringCalculator.Add(input);

            Assert.Equal(expected, actual);
        }

    }
}
