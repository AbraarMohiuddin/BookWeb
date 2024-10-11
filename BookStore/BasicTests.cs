// BasicTests.cs

using NuGet.ContentModel;
using Xunit;

namespace BookStore
{
    public class BasicTests
    {
        [Fact]
        public void SimpleTest_ShouldPass()
        {
            // Arrange
            int expected = 5;
            int actual = 5;

            // Act & Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SimpleTest_ShouldFail()
        {
            // Arrange
            int expected = 5;
            int actual = 3;

            // Act & Assert
            Assert.NotEqual(expected, actual);
        }
    }
}
