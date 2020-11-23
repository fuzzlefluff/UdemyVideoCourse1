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

            var viewModel = new MovieCustomerListViewModel();
            viewModel.Customers = GetCustomers();

            return View(viewModel);
        }
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null) { return HttpNotFound();}

            return View(customer);
        }
        private List<Customer> GetCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer{Id = 1, Name = "Joe Allan"},
                new Customer{Id = 2, Name = "Rachel G"}
            };
            return customers;
        }
    }
}