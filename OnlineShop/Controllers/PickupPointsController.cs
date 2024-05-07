using Microsoft.AspNetCore.Mvc;
using OnlineShop.DataContext;
using OnlineShop.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OnlineShop.Controllers
{
    public class PickupPointsController : Controller
    {
        private readonly OnlineShopContext _context;

        public PickupPointsController(OnlineShopContext context)
        {
            _context = context;
        }

        // GET: /PickupPoints
        public async Task<IActionResult> Index()
        {
            List<Пункты_выдачи> points = await _context.Пункты_выдачи.ToListAsync();
            return View(points);
        }
    }
}
