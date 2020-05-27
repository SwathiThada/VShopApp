using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VShopApp.Models;

namespace VShopApp.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers -- list of customers
        public ActionResult Index()
        {
            var customers = GetCustomers();
           
            return View(customers);
        }
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(cust => cust.Id == id);
            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 01 , Name = "Swathi Thada"},
                new Customer { Id = 02,  Name = "Prashant Keshireddy"},
                new Customer { Id = 03, Name = "Pruthvi Thada"}
            };
        }
        
    }
}