using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class Заказы
    {
        [Key]
        public int Код_Заказа { get; set; }

        public int Код_Обслуживания { get; set; }

        public int Код_Клиента { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Общая_стоимость_заказа { get; set; }

        [StringLength(50)]
        public string Статус_заказа { get; set; }

        [DataType(DataType.Date)]
        public DateTime Дата_заказа { get; set; }

        [ForeignKey("Код_Обслуживания")]
        public Обслуживание Обслуживание { get; set; }

        [ForeignKey("Код_Клиента")]
        public Клиенты Клиенты { get; set; }
    }
}