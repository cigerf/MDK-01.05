using cafe.Models;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace cafe.test.Tests.Models
{
    public class ClientModelTests
    {
        [Fact]
        public void Client_WithValidData_ShouldBeValid()
        {
            // Arrange
            var client = new Clients
            {
                NickName = "JohnDoe",
                Fullname = "John Doe",
                BonusPoint = 500,
                Email = "john@example.com"
            };

            var context = new ValidationContext(client);
            var results = new List<ValidationResult>();

            // Act
            var isValid = Validator.TryValidateObject(client, context, results, true);

            // Assert
            Assert.True(isValid);
            Assert.Empty(results);
        }
    }
}