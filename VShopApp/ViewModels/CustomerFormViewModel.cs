using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VShopApp.Models;

namespace VShopApp.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
        
    }
}