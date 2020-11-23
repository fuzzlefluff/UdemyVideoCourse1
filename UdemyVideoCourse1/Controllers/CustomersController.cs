using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UdemyVideoCourse1.Models;
using UdemyVideoCourse1.ViewModels;

namespace UdemyVideoCourse1.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                //new Customer{Name = "Joe Allan"},
                //new Customer{Name = "Rachel G"}
            };
            var viewModel = new CustomerViewModel

            {
                Customers = customers
            };
            
            return View(viewModel);
        }
    }
}