using OnlineShop.DataContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication;
using System.Text;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Authorization;

namespace OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        // Действие для отображения главной страницы
        public IActionResult Index()
        {
            return View();
        }
    }
}

