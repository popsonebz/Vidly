using Vidly.Models.Customers;
using System.Collections.Generic;
using System;
using System.Linq;
namespace Vidly.ViewModels
{
    public class CustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
        
        
    }
}