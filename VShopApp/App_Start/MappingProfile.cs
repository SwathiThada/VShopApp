using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VShopApp.Dtos;
using VShopApp.Models;

namespace VShopApp.App_Start
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(m => m.Id, Opt => Opt.Ignore()); 
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MovieDto, Movie>().ForMember(m => m.Id, Opt => Opt.Ignore());
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
           
        }
    }
}