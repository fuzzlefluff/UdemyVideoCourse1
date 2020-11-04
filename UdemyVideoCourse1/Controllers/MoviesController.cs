using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UdemyVideoCourse1.Models;

namespace UdemyVideoCourse1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Index()
        {
            var movie = new Movie() { Name = "Shrek!" };

            return View();
        }
    }
}