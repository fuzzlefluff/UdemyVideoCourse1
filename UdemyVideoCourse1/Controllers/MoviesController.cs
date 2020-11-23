﻿using System;
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
            var movies = new List<Movie>
            {
                //new Movie{Name = "Toy Story"},
                //new Movie{Name = "Rocket Blast"}
            };
            var viewModel = new MovieViewModel()

            {
               Movies = movies
            };
            return View(viewModel);
        }
       
    }
}