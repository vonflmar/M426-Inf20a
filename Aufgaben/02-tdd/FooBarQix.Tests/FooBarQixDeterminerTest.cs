using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Fact]
        public void TestIfNumberIsDividable()
        {
            //Arrange
            int input = 4;
            string expected = "4";
            FooBarQixDeterminer foobardeterminer = new FooBarQixDeterminer();

            // Act
            string actual = foobardeterminer.Determine(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}