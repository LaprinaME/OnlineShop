using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.ViewModels
{
    // Модель для авторизации
    public class LoginViewModel
    {
        public required string Login { get; set; }
        public required string Password { get; set; }
    }
}
        