using cafe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe.test.Models
{
    public class ClientTest
    {
        [Fact]
        public void Client_WithValidData_ShouldBeValid()
        {
            // Создаем объект клиента с валидными значениями.
            var client = new Clients
            {
                NickName = "JohnDoe",           // Обязательное поле, от 2 до 50 символов
                Fullname = "John Doe",          // Обязательное поле, не длиннее 100 символов
                BonusPoint = 500,               // В пределах допустимого диапазона 0–10000
                Email = "john@example.com"      // Корректный формат Email
            };

            // Создаем контекст валидации на основе объекта
            var context = new ValidationContext(client);

            // Сюда будут записаны ошибки валидации, если они есть
            var results = new List<ValidationResult>();

            // Проводим валидацию объекта с учетом всех атрибутов [Required], [Range] и т.п.
            var isValid = Validator.TryValidateObject(client, context, results, true);

            // Ожидаем, что валидация прошла успешно (все поля корректны)
            Assert.True(isValid);

            // Также убеждаемся, что список ошибок пуст
            Assert.Empty(results);
        }

        // Тест проверяет, что если NickName слишком короткий, то объект будет невалиден
        [Fact]
        public void Client_WithInvalidNickName_ShouldBeInvalid()
        {
            // Arrange
            var client = new Clients
            {
                NickName = "A",                 // ❌ меньше 2 символов
                Fullname = "John Doe",
                BonusPoint = 500,
                Email = "john@example.com"
            };

            var context = new ValidationContext(client);
            var results = new List<ValidationResult>();

            // Act
            var isValid = Validator.TryValidateObject(client, context, results, true);

            // Assert
            Assert.False(isValid);
            Assert.Contains(results, r => r.ErrorMessage != null && r.ErrorMessage.Contains("NickName должен быть от 2 до 50 символов"));
        }
    }
}
