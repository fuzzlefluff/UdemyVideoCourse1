﻿using System;
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
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }
        // GET: Movies/Random
        public ActionResult Index()
        {

            var viewModel = new MovieCustomerListViewModel();
            viewModel.Movies = _context.Movies.ToList();
            return View(viewModel);
        }
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null) { return HttpNotFound(); }

            return View(movie);
        }
    }
}