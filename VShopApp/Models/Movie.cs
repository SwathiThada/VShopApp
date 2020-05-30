using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VShopApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Genre")]
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        [Display (Name ="Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display (Name ="Date Added")]
        public DateTime DateAdded { get; set; }
        public int NumberInStock { get; set; }
    }
}