using Microsoft.AspNetCore.Mvc;

namespace Avengers_MVC.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FavoriteMovies()
        {
            return View();
        }

    }
}
