using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VShopApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength (50)]
        public string  Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }

        public int MembershipId { get; set; }

    }
}