﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VShopApp.Models;


namespace VShopApp.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public int GenreId { get; set; }
        public GenreDto Genre { get; set; }
        [Required]
        public DateTime? ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        [Required]
        
        [Range(1, 20)]
        public int? NumberInStock { get; set; }
    }
}