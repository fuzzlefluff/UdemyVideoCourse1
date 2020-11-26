﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UdemyVideoSite.Models;
using UdemyVideoSite.ViewModels;
using System.Data.Entity;

namespace UdemyVideoSite.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }

        // GET: Customer
        public ActionResult Index()
        {

            var viewModel = new MovieCustomerListViewModel();
            viewModel.Customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(viewModel);
        }
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null) { return HttpNotFound(); }

            return View(customer);
        }
    }
}