using Microsoft.AspNetCore.Mvc;
using OnlineShop.DataContext;
using OnlineShop.Models;
using OnlineShop.ViewModels;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OnlineShop.Controllers
{
    public class DeleteProductController : Controller
    {
        private readonly OnlineShopContext _context;

        public DeleteProductController(OnlineShopContext context)
        {
            _context = context;
        }

        // GET: /DeleteProduct
        public async Task<IActionResult> Index()
        {
            var products = await _context.Товары
                .Select(p => new DeleteProductViewModel
                {
                    ProductId = p.Код_Товара,
                    Name = p.Наименование,
                    Price = p.Цена,
                    Rating = p.Рейтинг_товара,
                    Category = p.Категория,
                    Brand = p.Бренд,
                    Quantity = p.Количество,
                    Manufacturer = p.Производитель
                })
                .ToListAsync();

            return View(products);
        }

        // POST: /DeleteProduct/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _context.Товары.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Товары.Remove(product);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
