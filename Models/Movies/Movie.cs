using System;
namespace Vidly.Models.Movies
{
    public class Movie
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public int NumberInStock { get; set; }
        public Genre Genre { get; set; }
        public Genre GenreId { get; set; }
        
        
        
    }
}