using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UdemyVideoCourse1.Models;
using UdemyVideoCourse1.ViewModels;


namespace UdemyVideoCourse1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Index()
        {
           
            var viewModel = new MovieViewModel()

            {
               Movies = GetMovies()
            };
            return View(viewModel);
        }
        private List<Movie> GetMovies()
        {
            var movies = new List<Movie>
            {
                new Movie{Id = 1, Name = "Toy Story"},
                new Movie{Id = 2, Name = "Rocket Blast"}
            };
            return movies;
        }

    }
}