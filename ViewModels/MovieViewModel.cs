using Vidly.Models.Movies;
using System.Collections.Generic;
using System;
using System.Linq;
namespace Vidly.ViewModels
{
    public class MovieViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
        
        
    }
}