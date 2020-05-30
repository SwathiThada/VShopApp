using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VShopApp.Models;
using System.Data.Entity;

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
            //base.Dispose(disposing);
            _context.Dispose();
        }

        //Movies
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
            
        }
        //// GET: Movies/Random
        //public ActionResult Random()
        //{
        //    var movie = new Movie() { Id = 1, Name = "Thappad" };
        //    // return View(movie);
        //    //return Content("Hello world");
        //    //return HttpNotFound();
        //    //return new EmptyResult();
        //    return RedirectToAction("Index");

        //}
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(c => c.Id ==id);
            return View(movie);
        }
        //private IEnumerable<Movie> GetMovies()
        //{
        //    return new List<Movie>
        //    {
        //        new Movie { Id = 1, Name = "Thappad"},
        //        new Movie { Id = 2, Name = "Jaanu"},
        //        new Movie { Id = 3, Name = "Ala Vaikunthapuramlo"}
        //    };
        //}
    }
}