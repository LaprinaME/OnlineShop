using Microsoft.AspNetCore.Mvc;
using OnlineShop.DataContext;
using OnlineShop.Models;
using OnlineShop.ViewModels;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OnlineShop.Controllers
{
    public class AccountController : Controller
    {
        private readonly OnlineShopContext _context;

        public AccountController(OnlineShopContext context)
        {
            _context = context;
        }

        // POST: /Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _context.Пользователи
                    .Include(u => u.Роли)
                    .FirstOrDefaultAsync(u => u.Логин == model.Login && u.Пароль == model.Password);

                if (user != null)
                {
                    if (user.Роли != null)
                    {
                        var roleCode = user.Код_Роли;

                        if (roleCode == 2)
                        {
                            return RedirectToAction("Index", "MenuEmployee");
                        }
                        else if (roleCode == 3)
                        {
                            return RedirectToAction("Index", "MenuAdmin");
                        }
                        else if (roleCode == 1)
                        {
                            return RedirectToAction("Index", "Menu");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Роль пользователя не определена");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Неверный логин или пароль");
                }
            }
            return View(model);
        }

        // POST: /Account/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (await _context.Пользователи.AnyAsync(u => u.Логин == model.Login))
                {
                    ModelState.AddModelError("Login", "Пользователь с таким логином уже существует");
                    return View(model);
                }

                if (await _context.Роли.AllAsync(r => r.Код_Роли != model.RoleCode))
                {
                    ModelState.AddModelError("RoleCode", "Роль с указанным кодом не существует");
                    return View(model);
                }

                var account = new Пользователи
                {
                    Логин = model.Login,
                    Пароль = model.Password,
                    Код_Пользователя = model.UserCode
                };

                account.Роли = await _context.Роли.FindAsync(model.RoleCode);

                _context.Add(account);
                await _context.SaveChangesAsync();

                if (model.RoleCode == 2)
                {
                    return RedirectToAction("Index", "MenuEmployee");
                }
                else if (model.RoleCode == 3)
                {
                    return RedirectToAction("Index", "MenuAdmin");
                }
                else if (model.RoleCode == 3)
                {
                    return RedirectToAction("Index", "Menu");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(model);
        }

        // GET: /Account/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View("~/Views/Account/Login.cshtml");
        }

        // GET: /Account/Register
        [HttpGet]
        public IActionResult Register()
        {
            return View("~/Views/Account/Register.cshtml");
        }

        // GET: /Account/RegistrationSuccess
        public IActionResult RegistrationSuccess()
        {
            return View("~/Views/Home/Index.cshtml");
        }
    }
}
