using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        [Route("movies")]
        public ActionResult Index()
        {
            var availableMovies = new List<Movie>
            {
                new Movie { Name = "Chicken Run!" },
                new Movie { Name = "Empire Strikes Back" }
            };

            var viewmodel = new MoviesViewModel()
            {
                movies = availableMovies
            };

            return View(viewmodel);
        }
        
        // GET
        [Route("movies/random")]
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Chicken Run!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Todd Berry", Id = 1 },
                new Customer { Name = "Sarah Candle", Id = 2 }
            };

            var viewmodel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            
            return View(viewmodel);
        }

//        [Route("movies/released/{year:regex(\\d{4}/{month:regex(\\d{4}):range(1, 12)")]
//        public ActionResult ByReleaseDate(int year, int month)
//        {
//            return View();
//        }
    }
}