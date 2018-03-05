using System;
using AutoMapper;
using System.Linq;
using System.Collections.Generic;
using Vidly.Models.Customers;
using Vidly.DTO;
namespace Vidly
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();
            //CreateMap<Customer, CustomerDto>()
             //   .ReverseMap();
        }
        
    }
}