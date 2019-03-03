﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using VideoRentalApp.Models;
using VideoRentalApp.ViewModels;

namespace VideoRentalApp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel()
            {
                MembershipTypes = membershipTypes
            };

            return View(viewModel);
        }

        // GET: Customer
        public ActionResult Index()
        {
            /* The .Include introduces Eager loading so that there is only 1 Query sent to database.
               QUERY: Customers and related MembershipType
               Instead of 
               Query: Customers
               Query: Associated MembershipTypes */
            var customer = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customer);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }

        [HttpPost]
        public ActionResult Create(NewCustomerViewModel viewModel)
        {


            return View();
        }
    }
}