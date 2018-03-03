using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using Vidly.Models;
using Vidly.Data;
using Microsoft.EntityFrameworkCore;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController(ApplicationDbContext context)
        {
            _context = context; //its initialized here

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index() //vieresult is a subtype of actionresult
        {
            //var movies = _context.Movies; // remember, we defined Movies context in ApplicationDbContext.cs
            //note: this query will not excute until you use it in the view

            //to force it to execute the sql here, we use
            var movies = _context.Movies.Include(c => c.Genre).ToList();
            
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movies = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);

            if (movies == null)
            {
                return NotFound();  
            }
            return View(movies);
        }
        
    }
}



