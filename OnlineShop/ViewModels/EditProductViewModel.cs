using System.ComponentModel.DataAnnotations;

namespace OnlineShop.ViewModels
{
    public class EditProductViewModel
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }

        public double Rating { get; set; }

        public string Category { get; set; }

        public string Brand { get; set; }

        public int Quantity { get; set; }

        public string Manufacturer { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
    }
}
