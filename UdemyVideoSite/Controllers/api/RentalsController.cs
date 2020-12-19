using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using UdemyVideoSite.Dtos;
using UdemyVideoSite.Models;

namespace UdemyVideoSite.Controllers.api
{
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }
        // POST /api/newRental
        [HttpPost]
        public IHttpActionResult NewRental(NewRentalDto newRental)
        {
            if (newRental.MovieIds.Count == 0) { return BadRequest("No Movie Ids have been given");}

            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);
            if (customer == null) { return BadRequest("CustomerId is not valid.");}

            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id)).ToList();

            if (movies.Count != newRental.MovieIds.Count) { return BadRequest("One or more MovieIds are invalid.");}

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0) { return BadRequest("A movie is not available.");}

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };
                _context.Rentals.Add(rental);
            }
            _context.SaveChanges();
            return Ok();
        }
    }
}
