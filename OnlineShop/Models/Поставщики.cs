using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Models
{
    public class Поставщики
    {
        [Key]
        public int Код_Поставщика { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Цена_закупки { get; set; }

        [Required]
        [StringLength(255)]
        public string Наименование_фирмы { get; set; }

        [StringLength(20)]
        public string Контактный_телефон { get; set; }

        [StringLength(255)]
        public string Электронная_почта { get; set; }

        [StringLength(255)]
        public string ФИО { get; set; }

        [StringLength(255)]
        public string Сайт { get; set; }
    }
}