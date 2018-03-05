
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly.Data;
using Vidly.Models.Customers;
using System.Net.Http;


namespace Vidly.Controllers.API
{
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {

        private ApplicationDbContext _context; //we need to declare this because it connects us to the database
        public CustomersController(ApplicationDbContext context)
        {
            _context = context; //its initialized here

        }
        
        static List<string> strings = new List<string>()
        {
            "customers0", "customers1","customers2"
        };
        //private DatabaseContext db = new DatabaseContext();
         //GET api/customers
        [HttpGet]
        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }
        

        // GET api/customers/5
        [HttpGet("{id}")]
        public IActionResult GetCustomers(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if(customer == null)
            {
                return NotFound();
            }
            return new ObjectResult(customer);
        }
        // Post api/customers/
        [HttpPost]
        public IActionResult Create([FromBody] Customer customer)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            _context.Customers.Add(customer);
            _context.SaveChanges();

            return new NoContentResult();
        }

        // Put api/customers/1
        [HttpPut("{id}")]
        public IActionResult UpdateCustomer(int id, [FromBody] Customer customer)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
            {
                return NotFound();
            }
            customerInDb.Name = customer.Name;
            customerInDb.Birthdate = customer.Birthdate;
            customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter ;
            customerInDb.MembershipTypeId = customer.MembershipTypeId;

            _context.SaveChanges();

            return new NoContentResult();
        }

        // Delete api/customers/1
        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
            {
                return NotFound();
            }
            _context.Customers.Remove(customerInDb);

            _context.SaveChanges();

            return new NoContentResult();
        }
    }
}