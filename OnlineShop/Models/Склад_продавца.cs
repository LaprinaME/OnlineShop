using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class Склад_продавца
    {
        [Key]
        public int Код_Склада_продавца { get; set; }

        public int Код_Продавца { get; set; }

        public int Код_Товара { get; set; }

        public int Код_Поставщика { get; set; }

        [StringLength(50)]
        public string Статус_товара { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Описание { get; set; }

        public int Количество_на_складе { get; set; }

        [DataType(DataType.Date)]
        public DateTime Дата_поступления { get; set; }

        [ForeignKey("Код_Продавца")]
        public Продавцы Продавцы { get; set; }

        [ForeignKey("Код_Товара")]
        public Товары Товары { get; set; }

        [ForeignKey("Код_Поставщика")]
        public Поставщики Поставщики { get; set; }
    }
}