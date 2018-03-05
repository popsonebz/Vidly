using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using Vidly.Models;
using Vidly.Data;
using Microsoft.EntityFrameworkCore;
using Vidly.Models.Movies;
using Vidly.ViewModels;

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
       
        public ActionResult New()
        {
          var genres = _context.Genre.ToList();
          var viewModel = new MovieViewModel { Genres = genres};
          return View(viewModel);
        } 

        [HttpPost]
        public ActionResult Create(Movie movie) //create or update customer
        {
            if (movie.Id == 0)
            {
                _context.Movies.Add(movie);
            }else{
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.DateAdded = movie.DateAdded;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.GenreId = movie.GenreId;
            }
            
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        } 

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movie == null)
            {
                return NotFound();  
            }
            var viewModel = new MovieViewModel
            {Movie = movie,
             Genres = _context.Genre.ToList()};
            
            return View("New", viewModel);
        }
        
    }
}



