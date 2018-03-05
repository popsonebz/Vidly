using System;
using System.ComponentModel.DataAnnotations;
namespace Vidly.Models.Movies
{
    public class Movie
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public byte NumberInStock { get; set; }
        
        //Foreign key
        [Display(Name = "Genre")]
        [Required]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }   
    }
}