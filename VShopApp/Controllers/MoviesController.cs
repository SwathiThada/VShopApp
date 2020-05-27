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
            return HttpNotFound();
            //return EmptyResult;
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
    }
}