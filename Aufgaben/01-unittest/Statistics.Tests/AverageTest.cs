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
            List<int> numbers = new List<int> { 2, 4 };
            double expected = 3;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestMeanOfFiveNumbers()
        {
            List<int> numbers = new List<int> { 2, 4, 4, 5, 6 };
            double expected = 4.2;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestMeanOfNoNumbers()
        {
            List<int> numbers = new List<int> { };
            Average average = new Average();

            Assert.Throws<ArgumentException>(() => average.Mean(numbers));
        }
        [Fact]
        public void TestMedianForOddNumbers()
        {
            List<int> numbers = new List<int> { 2, 4, 4, 5, 6 };
            double expected = 4;
            Average average = new Average();

            double actual = average.Median(numbers);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestMedianForEvenNumbers()
        {
            List<int> numbers = new List<int> { 2, 1, 5, 6 };
            double expected = 3.5;
            Average average = new Average();

            double actual = average.Median(numbers);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestMedianForNoNumbers()
        {
            List<int> numbers = new List<int> { };
            Average average = new Average();

            Assert.Throws<ArgumentException>(() => average.Median(numbers));
        }
    }
}
