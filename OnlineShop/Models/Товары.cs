using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class Товары
    {
        [Key]
        public int Код_Товара { get; set; }

        [Required]
        [StringLength(255)]
        public string Наименование { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Цена { get; set; }

        public double Рейтинг_товара { get; set; } // Изменение типа на double

        [StringLength(50)]
        public string Категория { get; set; }

        [StringLength(255)]
        public string Бренд { get; set; }

        public int Количество { get; set; }

        [StringLength(255)]
        public string Производитель { get; set; }
    }
}