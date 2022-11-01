using System;
using System.Collections.Generic;
using Xunit;

namespace Statistics.Tests
{
    public class MedianTest
    {
        [Fact]
        public void TestMedianForOddNumberOfElements(){
            List<int> numbers = new List<int> { 1, 2, 8, 7, 6 };
            Median median = new Median();

            double result = median.calculateMedian(numbers);

            Assert.Equal(6, result);
        }

        [Fact]
        public void TestMedianForEvenNumberOfElements(){
            List<int> numbers = new List<int> {5, 2, 1, 6, 7, 8};
            Median median = new Median();

            double actual = median.calculateMedian(numbers);

            Assert.Equal(5.5, actual);
        }

        [Fact]
        public void TestMedianForNoElements(){
            List<int> numbers = new List<int> {};
            Median median = new Median();

            Assert.Throws<ArgumentException>(() => 
                median.calculateMedian(numbers)
            );
        }
    }
}
