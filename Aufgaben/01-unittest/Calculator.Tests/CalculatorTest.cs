using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAddition()
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
        public void TestSubtraction()
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
        public void TestMultiplication()
        {
            // Arrange
            int a = 2;
            int b = 3;
            int expected = 6;
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Multiply(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivision()
        {
            // Arrange
            int a = 6;
            int b = 4;
            double expected = 1.5;
            Calculator calculator = new Calculator();

            // Act
            double actual = calculator.Division(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivisionZero()
        {
            // Arrange
            int a = 6;
            int b = 0;
            Calculator calculator = new Calculator();

            // Assert
            Assert.Throws<ArgumentException>(() => calculator.Division(a, b));
        }
        
    }
}
