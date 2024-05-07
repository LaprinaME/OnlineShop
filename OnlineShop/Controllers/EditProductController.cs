using Microsoft.AspNetCore.Mvc;
using OnlineShop.DataContext;
using OnlineShop.Models;
using OnlineShop.ViewModels;
using System.Linq;

namespace OnlineShop.Controllers
{
    public class EditProductController : Controller
    {
        private readonly OnlineShopContext _context;

        public EditProductController(OnlineShopContext context)
        {
            _context = context;
        }

        // GET: EditProduct/Index
        [HttpGet]
        public IActionResult Index()
        {
            var viewModel = new EditProductViewModel(); // Создание экземпляра модели
            return View(viewModel); // Передача модели в представление
        }

        // POST: EditProduct/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EditProductViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var product = _context.Товары.FirstOrDefault(p => p.Код_Товара == viewModel.ProductId);
                if (product == null)
                {
                    return NotFound();
                }

                // Update product information
                product.Наименование = viewModel.Name;
                product.Цена = viewModel.Price;
                product.Рейтинг_товара = viewModel.Rating;
                product.Категория = viewModel.Category;
                product.Бренд = viewModel.Brand;
                product.Количество = viewModel.Quantity;
                product.Производитель = viewModel.Manufacturer;

                _context.SaveChanges();

                return RedirectToAction("Index", "MenuAdmin");
            }

            return View("Index", viewModel);
        }
    }
}
