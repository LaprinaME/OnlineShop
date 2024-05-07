using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{
    public class MenuEmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
