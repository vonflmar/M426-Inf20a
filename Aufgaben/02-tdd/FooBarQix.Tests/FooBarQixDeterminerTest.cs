using System;
using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Fact]
        public void determine_numberTwo_returnsNumberTwo() {
            FooBarQixDeterminer fooBarQix = new FooBarQixDeterminer();
            string expected = "2";

            string result = fooBarQix.determine(2);

            Assert.Equals(expected, result);
        }

        [Fact]
        public void determine_numberThree_returnsFoo() {
            FooBarQixDeterminer fooBarQix = new FooBarQixDeterminer();
            string expected = "Foo";

            string result = fooBarQix.determine(3);

            Assert.Equals(expected, result);
        }

        [Fact]
        public void determine_numberFive_returnsBar() {
            FooBarQixDeterminer fooBarQix = new FooBarQixDeterminer();
            string expected = "Bar";

            string result = fooBarQix.determine(5);

            Assert.Equals(expected, result);
        }

        [Fact]
        public void determine_numberSix_returnsFoo() {
            FooBarQixDeterminer fooBarQix = new FooBarQixDeterminer();
            string expected = "Foo";

            string result = fooBarQix.determine(6);

            Assert.Equals(expected, result);
        }

        [Fact]
        public void determine_numberSeven_returnsQix() {
            FooBarQixDeterminer fooBarQix = new FooBarQixDeterminer();
            string expected = "Qix";

            string result = fooBarQix.determine(7);

            Assert.Equals(expected, result);
        }

        [Fact]
        public void determine_number105_returnsFooBarQix() {
            FooBarQixDeterminer fooBarQix = new FooBarQixDeterminer();
            string expected = "FooBarQix";

            string result = fooBarQix.determine(105);

            Assert.Equals(expected, result);
        }
    }
}