using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using VideoRental.Models;
using VideoRental.ViewModels;

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
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            // Instead of View(movie), this is the longer equivalent way
            //ViewData.Model = movie;

            // This is the old way which shouldn't be used as you have to match the "Movie" property in the View
            //ViewData["Movie"] = movie;

            // Returns a ViewResult
            return View(viewModel);

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

        // Returns Content id = 52 for example available at /Movies/Edit/52 or /Movies/Edit?id=1
        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            
            return Content(string.Format($"pageIndex={pageIndex}&sortBy={sortBy}"));
        }

        // Implements the Attribute route
        // The : specifies restraints
        // The Attribute first tries to find an action called "released" then falls back to 2 parameters called year and month to find ByReleaseDate() 
        [Route("movie/released/{year:regex(\\d{4})}/{months:range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int months)
        {
            return Content($"{year} / {months}");
        }
    }
}