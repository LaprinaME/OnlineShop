﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(255)]
        public string Login { get; set; }

        [Required]
        [StringLength(255)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Поле Код роли обязательно для заполнения")]
        [Display(Name = "Код роли")]
        public int RoleCode { get; set; }

        [Required(ErrorMessage = "Поле Код пользователя обязательно для заполнения")]
        [Display(Name = "Код пользователя")]
        public int UserCode { get; set; }

        [Required]
        [StringLength(255)]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }
    }
}