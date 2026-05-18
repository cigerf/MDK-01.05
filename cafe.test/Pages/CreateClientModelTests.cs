using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using cafe.Data;
using cafe.Models;
using Xunit;
using System.Linq;

namespace cafe.test.Tests.Pages
{
    public class CreateClientModelTests
    {
        private ApplicationDbContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            return new ApplicationDbContext(options);
        }

        [Fact]
        public void OnPost_ShouldReturnPage_WhenModelStateIsInvalid()
        {
            // Arrange
            var context = GetDbContext();
            var pageModel = new cafe.Pages.Clients.CreateModel(context);

            pageModel.ModelState.AddModelError("NickName", "Required");

            // Act
            var result = pageModel.OnPost();

            // Assert
            Assert.IsType<PageResult>(result);
            Assert.Equal(0, context.Clients.Count());
        }
    }
}