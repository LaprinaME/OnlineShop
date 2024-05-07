using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{
    public class MenuAdminController : Controller
    {
        // GET: /MenuAdmin
        public IActionResult Index()
        {
            return View();
        }
    }
}
