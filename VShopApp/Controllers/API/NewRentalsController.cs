using AutoMapper;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VShopApp.Dtos;
using VShopApp.Models;

namespace VShopApp.Controllers.API
{
    public class NewRentalsController : ApiController
    {
        private  ApplicationDbContext _context;
            public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }
    //POST /api/post
    [HttpPost]
    public IHttpActionResult CreateNewRentals(NewRentalsDto newRentalsDto)
        {
            //if (!ModelState.IsValid)
            //    return BadRequest();

            //if (newRentalsDto.MovieIds.Count == 0)
            //    return BadRequest("No Movie Ids have been given");

            var customer = _context.Customers.Single(c => c.Id == newRentalsDto.CustomerId);
                                   
            var movies = _context.Movies.Where(m => newRentalsDto.MovieIds.Contains(m.Id)).ToList();
            //if (movies.Count != newRentalsDto.MovieIds.Count)
            //    return BadRequest("One or More Movie Ids are invalid");

            foreach(var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available");

                movie.NumberAvailable--;
                var rentals = new Rentals
                {
                    Customer = customer,
                     Movie = movie,
                     DateRented = DateTime.Now
                };
                _context.Rentals.Add(rentals);

            }

            //var rentals = Mapper.Map<NewRentalsDto, Rentals>(newRentalsDto);
            _context.SaveChanges();
            return NotFound();

        }
    }
}
