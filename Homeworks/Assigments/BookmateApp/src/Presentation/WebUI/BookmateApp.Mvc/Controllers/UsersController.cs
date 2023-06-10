using BookmateApp.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookmateApp.Mvc.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Login(UserLoginViewModel userLogin)
        {
            return View();
        }
    }
}
