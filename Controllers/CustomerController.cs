using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using Vidly.Models;
using Vidly.Data;
using Microsoft.EntityFrameworkCore;
using Vidly.ViewModels;
using Vidly.Models.Customers;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context; //we need to declare this because it connects us to the database
        public CustomersController(ApplicationDbContext context)
        {
            _context = context; //its initialized here

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index() //vieresult is a subtype of actionresult
        {
            //var customers = _context.Customers; // remember, we defined Customers context in ApplicationDbContext.cs
            //note: this query will not excute until you use it in the view

            //to force it to execute the sql here, we use
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return NotFound();  
            }
            return View(customer);
        }

        public ActionResult New()
        {
          var membershipTypes = _context.MembershipType.ToList();
          var viewModel = new CustomerViewModel { MembershipTypes = membershipTypes};
          return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }

        
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return NotFound();  
            }
            var viewModel = new CustomerViewModel
            {Customer = customer,
             MembershipTypes = _context.MembershipType.ToList()};
            
            return View("New", viewModel);
        }
    }
    
}