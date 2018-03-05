
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly.Data;
using Vidly.Models.Customers;
using System.Net.Http;
using Vidly.DTO;
using AutoMapper;


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
        
        //private DatabaseContext db = new DatabaseContext();
         //GET api/customers
        [HttpGet]
        //public IEnumerable<Customer> GetCustomers()
        public IEnumerable<CustomerDto> GetCustomers()
        {
            //return _context.Customers.ToList();
            return _context.Customers.ToList().Select(Mapper.Map<Customer, CustomerDto>);
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
            //return new ObjectResult(customer);

            return new ObjectResult(Mapper.Map<Customer, CustomerDto>(customer));
        }
        /* 
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

            return Ok();
        }
         */
         // Post api/customers/
        /*[HttpPost]
        public IActionResult Create([FromBody] CustomerDto customerDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();

            return Ok();
        }*/
        [HttpPost]
        public IActionResult Create([FromBody] CustomerDto customerDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();
            customerDto.Id = customer.Id;
            //return Created(new Uri(Request + "/" + customer.Id), customerDto);
            return Created($"/api/customers/{customer.Id}", customerDto);
            //$"/api/episodes/{episode.EpisodeNumber}", newEpisode
        }
        /* 
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

            return Ok();
        } */

         // Put api/customers/1
        [HttpPut("{id}")]
        public IActionResult UpdateCustomer(int id, [FromBody] CustomerDto customerDto)
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
            //map source to destination
            Mapper.Map(customerDto, customerInDb);

            _context.SaveChanges();

            return Ok();
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

            return Ok();
        }
    }
}