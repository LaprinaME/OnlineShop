using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class Сотрудники
    {
        [Key]
        public int Код_Сотрудника { get; set; }

        [Required]
        [StringLength(255)]
        public string ФИО { get; set; }

        [StringLength(50)]
        public string Должность { get; set; }

        public int Код_ПВЗ { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Зарплата { get; set; }

        [StringLength(20)]
        public string Номер_телефона { get; set; }

        [ForeignKey("Код_ПВЗ")]
        public Пункты_выдачи Пункты_выдачи { get; set; }
    }
}