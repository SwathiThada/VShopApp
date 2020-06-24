using System;
using System.Collections.Generic;
using VShopApp.Models;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.EnterpriseServices;
using VShopApp.Dtos;
using AutoMapper;
using System.Data.Entity;
//using System.Web.Mvc;

namespace VShopApp.Controllers.API
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        //GET/api/customers
        //public IEnumerable<CustomerDto> GetCustomers()
        //{
        //    return _context.Customers.
        //        Include( c => c.MembershipType).
        //        ToList().
        //        Select(Mapper.Map<Customer,CustomerDto>);
        //}
        public IHttpActionResult GetCustomers(string query = null)
        {
            var customersQuery = _context.Customers
                .Include(c => c.MembershipType);

            if (!String.IsNullOrWhiteSpace(query))
                customersQuery = customersQuery.Where(c => c.Name.Contains(query));


            var customerDtos = customersQuery
               .ToList()
               .Select(Mapper.Map<Customer, CustomerDto>);

            return Ok(customerDtos);
        }

            //GET /api/customers/1
            public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return NotFound();
            return Ok(Mapper.Map<Customer, CustomerDto>(customer));
        }
        //POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);

            _context.Customers.Add(customer);
            _context.SaveChanges();
            customerDto.Id = customer.Id;
            return Created(new Uri(Request.RequestUri + "/" + customer.Id),customerDto);
        }
        //PUT /api/customers/1
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                //throw new HttpResponseException(HttpStatusCode.BadRequest);
                BadRequest();

            var customerInDB = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDB == null)
                //throw new HttpResponseException(HttpStatusCode.NotFound);
                NotFound();

            Mapper.Map<CustomerDto, Customer>(customerDto, customerInDB);

            
            _context.SaveChanges();

            return Ok();

        }
        //DELETE /api/customers/1
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            
            var customerInDB = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Customers.Remove(customerInDB);
            _context.SaveChanges();
            return Ok();

        }
    }
}
