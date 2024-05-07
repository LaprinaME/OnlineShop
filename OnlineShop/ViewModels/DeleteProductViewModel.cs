using System.ComponentModel.DataAnnotations;

namespace OnlineShop.ViewModels
{
    public class DeleteProductViewModel
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public double Rating { get; set; }

        public string Category { get; set; }

        public string Brand { get; set; }

        public int Quantity { get; set; }

        public string Manufacturer { get; set; }
    }
}
