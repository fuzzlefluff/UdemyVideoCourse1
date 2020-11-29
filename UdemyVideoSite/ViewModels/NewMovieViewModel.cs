using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UdemyVideoSite.Models;

namespace UdemyVideoSite.ViewModels
{
    public class NewMovieViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}