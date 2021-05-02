using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.Models.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        
        public ActionResult Index()
        {
            return View(GetMovies());
        }

        public ActionResult Detail(int Id)
        {
            var movie = GetMovies().FirstOrDefault(p => p.Id == Id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }
        
        private List<Movie> GetMovies()
        {
            var movies = new List<Movie>
            {
                new Movie { Id =1, Name = "Shrek!" },
                new Movie { Id =2, Name = "Wall-e" }
            };
            return movies;
        }

        // GET: Movies/Random
        public ActionResult Random(string MovieId)
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customer = new List<Customer>
            {
                new Customer{Name = "Customer1" },
                new Customer{Name = "Customer2" }
            };

            var viewModel = new RandomCustomerViewModel()
            {
                Movie = movie,
                Customers = customer
            };

            return View(viewModel);
        }
    }
}