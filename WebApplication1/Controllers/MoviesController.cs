using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UdemyVideoSite.Models;
using UdemyVideoSite.ViewModels;

namespace UdemyVideoSite.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Index()
        {

            var viewModel = new MovieCustomerListViewModel();
            viewModel.Movies = GetMovies();
            return View(viewModel);
        }
        public ActionResult Details(int id)
        {
            var movie = GetMovies().SingleOrDefault(c => c.Id == id);

            if (movie == null) { return HttpNotFound(); }

            return View(movie);
        }
        private List<Movie> GetMovies()
        {
            var movies = new List<Movie>
            {
                new Movie{Id = 1, Name = "Toy Story"},
                new Movie{Id = 2, Name = "Shrek!"}
            };
            return movies;
        }
    }
}