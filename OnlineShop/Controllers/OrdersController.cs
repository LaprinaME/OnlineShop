using Microsoft.AspNetCore.Mvc;
using OnlineShop.DataContext;
using OnlineShop.Models; // Подключение пространства имен с моделями
using System.Linq;

namespace OnlineShop.Controllers
{
    public class OrdersController : Controller
    {
        private readonly OnlineShopContext _context; // Замените YourDbContext на ваш контекст данных

        public OrdersController(OnlineShopContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var orders = _context.Заказы.ToList(); // Получение всех заказов

            return View(orders);
        }
    }
}
