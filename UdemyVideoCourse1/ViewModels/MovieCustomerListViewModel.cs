using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UdemyVideoCourse1.Models;

namespace UdemyVideoCourse1.ViewModels
{
    public class MovieCustomerListViewModel
    {
        public List<Movie> Movies { get; set; }
        public List<Customer> Customers { get; set; }

        public MovieCustomerListViewModel()
        {
            Movies = new List<Movie>();
            Customers = new List<Customer>();
        }
    }
}