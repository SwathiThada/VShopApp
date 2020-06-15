using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VShopApp.Models;


namespace VShopApp.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]

        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        //[Min18YearsofAge]
        public DateTime? BirthDate { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }

        public MembershipTypeDto    MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }

    }
}