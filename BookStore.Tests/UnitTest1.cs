using Xunit;
using BookStore.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookStore.Data;
using System.Threading.Tasks;

namespace BookStore.Tests
{
    public class UnitTest1
    {
        private ApplicationDbContext GetInMemoryDbContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "BookStoreTestDb")
                .Options;
            return new ApplicationDbContext(options);
        }

        [Fact]
        public async Task Index_ReturnsViewResult()
        {
            // Arrange
            var context = GetInMemoryDbContext();
            var controller = new BooksController(context);

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
            var context = GetInMemoryDbContext();
            var controller = new BooksController(context);

            // Act
            var result = controller.Create();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult);
        }
    }
}
