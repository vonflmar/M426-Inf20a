using System;
using System.Collections.Generic;
using Xunit;

namespace Statistics.Tests
{
    public class AverageTest
    {
        [Fact]
        public void TestMeanOfTwoNumbers()
        {
            List<int> numbers = new List<int> { 4, 8 };
            double expected = 6;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanOfFiveNumbers()
        {
            List<int> numbers = new List<int> { 4, 8, 2, 9, 7};
            double expected = 6;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanOfNoNumbers()
        {
            List<int> numbers = new List<int> {};
            Average average = new Average();

            Assert.Throws<ArgumentException>(() => 
                average.Mean(numbers)
            );
        }
    }
}
