using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using VideoRental.Models;

namespace VideoRental.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        // Return type is ActionResult as it is generic but could be specific as ViewResult
        // public ViewResult Random()
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};

            // Returns a ViewResult
            return View(movie);

            // Returns a Partial View
            //return PartialView(movie);

            // Returns simple text
            //return Content("Hello World");

            // Redirects user to a specified URL
            // return Redirect("index.cshtml");

            // Redirect to a different action. The third parameter routeValues are optional and are not keywords
            // return RedirectToAction("Index", "Home", new {pageNo = 1, sortByThis = "name"});

            // Returns serialized JSON object
            // return Json(movie);

            // Returns a File
            // return File();

            // Returns a page not found error
            // return HttpNotFound();

            // Returns void
            // return new EmptyResult();
        }

        // Returns Content id = 52 for example available at /Movies/Edit/52
        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }
    }
}