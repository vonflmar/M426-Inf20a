using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAddThreeToTwoPIsFive() {
            // Arrange
            int a = 7;
            int b = 3;
            int expected = 10;
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSubtractFourFromSixIsTwo() {
            // Given
            int a = 6;
            int b = 5;
            int expected = 1;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.Subtract(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void multiplyFourByEightIsThirtyTwo() {
            int factorA = 4;
            int factorB = 8;
            Calculator calculator = new Calculator();

            int result = calculator.multiply(factorA, factorB);

            Assert.Equal(32, result);
        }

        [Fact]
        public void divideTwentyByFiveIsFour() {
            int dividend = 20;
            int divisor = 5;
            Calculator calculator = new Calculator();

            int result = calculator.divide(dividend, divisor);

            Assert.Equal(4, result);
        }

        [Fact]
        public void divideByZeroThrowsExeption() {
            int dividend = 20;
            int divisor = 0;
            Calculator calculator = new Calculator();

            Assert.Throws<ArgumentException>(() => 
                calculator.divide(dividend, divisor)
            );
        }
    }
}
