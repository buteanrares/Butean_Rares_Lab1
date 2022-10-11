using Microsoft.AspNetCore.Mvc;

namespace Butean_Rares_Lab1.Controllers
{
    public class CustomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Welcome()
        {
            return "Welcome, user";
        }

        public string CustomWelcome(string username)
        {
            return $"Welcome, {username}";
        }

        public string Params(string param1, int param2)
        {
            return $"Your input was {param1}, {param2}";
        }
    }
}
