using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAddThreeToTwoPIsFive()
        {
            // Arrange
            int a = 2;
            int b = 3;
            int expected = 5;
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSubtractFourFromSixIsTwo()
        {
            // Given
            int a = 6;
            int b = 4;
            int expected = 2;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.Subtract(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiplyFiveWithEightyFour()
        {
            // Given
            int a = 5;
            int b = 84;
            int expected = 420;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.Multiply(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivideSixtyNinebyTen()
        {
            // Given
            double a = 69;
            double b = 10;
            double expected = 6.9;
            Calculator calculator = new Calculator();

            // When
            double actual = calculator.Divide(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivideByZero()
        {
            // Given
            double a = 420;
            double b = 0;
            double expected = 420;
            Calculator calculator = new Calculator();


            Assert.Throws<ArgumentException>() => calculator.Divide(a, b);
        }
    }
}
