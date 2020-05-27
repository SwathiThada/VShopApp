using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VShopApp.Models;

namespace VShopApp.Controllers
{
    public class MoviesController : Controller
    {
        //Movies
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
            
        }
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Id = 1, Name = "Thappad" };
            // return View(movie);
            //return Content("Hello world");
            //return HttpNotFound();
            //return new EmptyResult();
            return RedirectToAction("Index");

        }
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Thappad"},
                new Movie { Id = 2, Name = "Jaanu"},
                new Movie { Id = 3, Name = "Ala Vaikunthapuramlo"}
            };
        }
    }
}