using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VShopApp.Models;
using System.Data.Entity;
using VShopApp.ViewModels;
using System.Web.UI.WebControls;

namespace VShopApp.Controllers
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
        }

        //Movies
        public ActionResult Index()
        {
            //var movies = _context.Movies.Include(m => m.Genre).ToList();
            //return View(movies);
            return View();

            
        }
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(c => c.Id ==id);
            return View(movie);
        }
        public ActionResult New()
        {
            var geners = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel
            {
                Movie = new Movie(),
                Genres = geners
            };
            return View("MovieForm",viewModel);
        }
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return HttpNotFound();
            else
            {
                var viewModel = new MovieFormViewModel
                {
                    Movie = movie,
                    Genres = _context.Genres.ToList()
                };
                return View("MovieForm", viewModel);
            }


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var ViewModel = new MovieFormViewModel
                {
                    Movie = movie,
                    Genres = _context.Genres.ToList()
                };
                return View("MovieForm", ViewModel);
            }
                               
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var MovieInDB = _context.Movies.Single(m => m.Id == movie.Id);
                MovieInDB.Name = movie.Name;
                MovieInDB.ReleaseDate = movie.ReleaseDate;
                MovieInDB.NumberInStock = movie.NumberInStock;
                MovieInDB.GenreId = movie.GenreId;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }
    }
    
}