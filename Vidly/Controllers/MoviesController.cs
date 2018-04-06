using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Chicken Run!"};
            
            return View(movie);
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return View();
        }
    }
}