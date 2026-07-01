using System.ComponentModel.DataAnnotations;

namespace cafe.Models
{
    public class Orders : EFModel
    {
        [Required(ErrorMessage = "Введите название заказа")]
        [StringLength(100, ErrorMessage = "Название не может быть длиннее 100 символов")]
        public new string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Введите номер заказа")]
        [Range(1, 999999, ErrorMessage = "Номер заказа от 1 до 999999")]
        public int NumberOrder { get; set; }

        [Required(ErrorMessage = "Укажите состав заказа")]
        [StringLength(500, ErrorMessage = "Состав заказа не может быть длиннее 500 символов")]
        public string OrderContains { get; set; } = string.Empty;

        [Required(ErrorMessage = "Введите общую сумму")]
        [Range(0.01, 999999.99, ErrorMessage = "Сумма от 0.01 до 999999.99")]
        public double TotalAmount { get; set; }

        [Required(ErrorMessage = "Выберите статус")]
        public string Status { get; set; } = "Ожидает";
    }
}