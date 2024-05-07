using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class Обслуживание
    {
        [Key]
        public int Код_Обслуживания { get; set; }

        public int Код_Сотрудника { get; set; }

        public int Код_Клиента { get; set; }

        [DataType(DataType.Date)]
        public DateTime Дата_обслуживания { get; set; }

        [ForeignKey("Код_Сотрудника")]
        public Сотрудники Сотрудники { get; set; }

        [ForeignKey("Код_Клиента")]
        public Клиенты Клиенты { get; set; }
    }
}