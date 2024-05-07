using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.ViewModels
{
    public class AddProductViewModel
    {
        [Required(ErrorMessage = "Поле 'Код товара' обязательно для заполнения.")]
        public int Код_Товара { get; set; }

        [Required(ErrorMessage = "Поле 'Наименование' обязательно для заполнения.")]
        [StringLength(255, ErrorMessage = "Наименование должно содержать не более 255 символов.")]
        public string Наименование { get; set; }

        [Required(ErrorMessage = "Поле 'Цена' обязательно для заполнения.")]
        [Range(0, 1000000, ErrorMessage = "Цена должна быть положительным числом.")]
        public decimal Цена { get; set; }

        [Required(ErrorMessage = "Поле 'Рейтинг товара' обязательно для заполнения.")]
        [Range(0, 5, ErrorMessage = "Рейтинг товара должен быть в диапазоне от 0 до 5.")]
        public double Рейтинг_товара { get; set; }

        [Required(ErrorMessage = "Поле 'Категория' обязательно для заполнения.")]
        [StringLength(50, ErrorMessage = "Категория должна содержать не более 50 символов.")]
        public string Категория { get; set; }

        [StringLength(255, ErrorMessage = "Бренд должен содержать не более 255 символов.")]
        public string Бренд { get; set; }

        [Required(ErrorMessage = "Поле 'Количество' обязательно для заполнения.")]
        [Range(0, int.MaxValue, ErrorMessage = "Количество должно быть неотрицательным числом.")]
        public int Количество { get; set; }

        [StringLength(255, ErrorMessage = "Производитель должен содержать не более 255 символов.")]
        public string Производитель { get; set; }
    }
}
