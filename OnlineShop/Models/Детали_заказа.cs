using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Models;

namespace OnlineShop.Models
{
    public class Детали_заказа
    {
        [Key]
        public int Код_Деталей_заказа { get; set; }

        public int Код_Заказа { get; set; }

        public int Код_Товара { get; set; }

        public int Количество_товара { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Цена_единицы { get; set; }

        [ForeignKey("Код_Заказа")]
        public Заказы Заказы { get; set; }

        [ForeignKey("Код_Товара")]
        public Товары Товары { get; set; }
    }
}