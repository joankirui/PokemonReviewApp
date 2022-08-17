using Microsoft.AspNetCore.Mvc;

namespace PokemonReviewApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
