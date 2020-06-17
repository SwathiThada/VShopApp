using AutoMapper;
using Microsoft.Ajax.Utilities;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VShopApp.Dtos;
using VShopApp.Models;
using System.Data.Entity;

namespace VShopApp.Controllers.API
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        //GET /api/movies
        public IEnumerable<MovieDto> GetMovies()
        {
            return _context.Movies.
                Include(g => g.Genre).
                ToList().Select(Mapper.Map<Movie, MovieDto>);
            
        }
        //GET api/movies/1
        public IHttpActionResult GetMovie(int id)
        {
            var Movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (Movie == null)
                return NotFound();

            return Ok(Mapper.Map<Movie, MovieDto>(Movie));

        }
        //POST api/movies
        [HttpPost]
        [Authorize (Roles = RoleName.CanManageMovies)]
        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var Movie = Mapper.Map<MovieDto, Movie>(movieDto);
            _context.Movies.Add(Movie);
            _context.SaveChanges();
            movieDto.Id = Movie.Id;
            return Created(new Uri(Request.RequestUri + "/" + Movie.Id), movieDto);
        }

        //PUT api/movies/1
        [HttpPut]
        public IHttpActionResult UpdateMovie(int id, MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var MovieInDB = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (MovieInDB == null)
                return NotFound();

             Mapper.Map<MovieDto, Movie>(movieDto, MovieInDB);
            _context.SaveChanges();
            return Ok();

        }
        //DELETE api/movies/1
        [HttpDelete]
        public IHttpActionResult DeleteMovie(int id)
        {
            var MovieInDB = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (MovieInDB == null)
                return NotFound();

            _context.Movies.Remove(MovieInDB);
            _context.SaveChanges();

            return Ok();
        }
    }
}
