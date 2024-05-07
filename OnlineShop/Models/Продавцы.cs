using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Models
{
    public class Продавцы
    {
        [Key]
        public int Код_Продавца { get; set; }

        [Required]
        [StringLength(255)]
        public string ФИО { get; set; }

        [StringLength(20)]
        public string Контактный_телефон { get; set; }

        [StringLength(255)]
        public string Электронная_почта { get; set; }
    }
}