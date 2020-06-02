﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VShopApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }
        [Required]
        [Display (Name ="Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Display (Name ="Date Added")]
        public DateTime DateAdded { get; set; }
        [Required]
        [Display ( Name = "Number In Stock")]
        public int? NumberInStock { get; set; }
    }
}