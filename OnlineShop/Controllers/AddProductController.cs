using Microsoft.AspNetCore.Mvc;
using OnlineShop.DataContext;
using OnlineShop.Models;
using OnlineShop.ViewModels;
using System.Threading.Tasks;

namespace OnlineShop.Controllers
{
    public class AddProductController : Controller
    {
        private readonly OnlineShopContext _context;

        public AddProductController(OnlineShopContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddProduct(AddProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Создание нового товара
                var товар = new Товары
                {
                    Код_Товара = model.Код_Товара,
                    Наименование = model.Наименование,
                    Цена = model.Цена,
                    Рейтинг_товара = model.Рейтинг_товара,
                    Количество = model.Количество,
                    Категория = model.Категория,
                    Бренд = model.Бренд,
                    Производитель = model.Производитель,
                };

                // Добавление товара в базу данных
                _context.Товары.Add(товар);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "MenuAdmin"); // Перенаправляем на страницу меню после успешного добавления товара
            }
            // Возвращение представления Index в случае невалидных данных
            return View("Index", model);
        }
    }
}
