using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class Клиенты
    {
        [Key]
        public int Код_Клиента { get; set; }

        [Required]
        [StringLength(255)]
        public string ФИО { get; set; }

        [StringLength(20)]
        public string Номер_телефона { get; set; }

        [StringLength(255)]
        public string Электронная_почта { get; set; }

        [StringLength(255)]
        public string Домашний_адрес { get; set; }
    }
}