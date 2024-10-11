using Xunit;
using BookStore.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BookStore.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task Index_ReturnsViewResult()
        {
            // Arrange
            var controller = new BooksController(null);

            // Act
            var result = await controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult);
        }

        [Fact]
        public void Create_ReturnsViewResult()
        {
            // Arrange
            var controller = new BooksController(null);

            // Act
            var result = controller.Create();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult);
        }
    }
}
