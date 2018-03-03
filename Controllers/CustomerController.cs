using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using Vidly.Models;
using Vidly.Data;
using Microsoft.EntityFrameworkCore;

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
          //TODO: Implement Realistic Implementation
          return View();
        }
    }
    
}