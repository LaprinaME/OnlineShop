using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
    public class Пункты_выдачи
    {
        [Key]
        public int Код_Пункта_выдачи { get; set; }

        [Required]
        [StringLength(255)]
        public string Адрес { get; set; }

        public int Оборот_заказов { get; set; }

        public double Рейтинг_пункта_выдачи { get; set; } // Изменено на double

        public int Количество_доступных_мест { get; set; }
    }
}

