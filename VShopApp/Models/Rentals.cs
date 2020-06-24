using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VShopApp.Models
{
    public class Rentals
    {
        public int Id { get; set; }
        //public int MovieId { get; set; }
        //public int CustomerId { get; set; }
        [Required]
        public Movie Movie { get; set; }
        [Required]
        public Customer Customer { get; set; }
        public DateTime DateRented { get; set; }
        public DateTime? DateReturned { get; set; }
    }
}