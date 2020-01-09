using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidLibrary.Models;
using VidLibrary.ViewModels;

namespace VidLibrary.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            var movie = new Movie() { Name = "Wall-E" };
            var movie2 = new Movie() { Name = "Cowboy Bebop" };

            return View();
        }



        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            //return Content("Yasss world!");
            //return HttpNotFound();
            //return RedirectResult("Index","Home");

            var customers = new List<Customer>
            {
                new Customer {Name = "John Smith"},
                new Customer {Name = "Mary Williams"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(year + "/" + month);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseYear(int year,int month)
        {
            return Content(year + "/" + month);
        }

    }

}