using System.ComponentModel.DataAnnotations;

namespace cafe.Models
{
    public class Clients : EFModel
    {
        [Required(ErrorMessage = "Введите NickName")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "NickName должен быть от 2 до 50 символов")]
        public string NickName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Введите полное имя")]
        [StringLength(100, ErrorMessage = "Полное имя не может быть длиннее 100 символов")]
        public string Fullname { get; set; } = string.Empty;

        [Range(0, 10000, ErrorMessage = "Бонусные баллы от 0 до 10000")]
        public int BonusPoint { get; set; }

        [Required(ErrorMessage = "Введите Email")]
        [EmailAddress(ErrorMessage = "Некорректный формат Email")]
        public string Email { get; set; } = string.Empty;
    }
}