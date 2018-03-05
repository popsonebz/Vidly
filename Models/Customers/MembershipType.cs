using System;
using System.Linq;
using System.Collections.Generic;
namespace Vidly.Models.Customers
               
{
    public class MembershipType
    {
        public int Id {get; set;}
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        //public ICollection<Customer> Customers { get; set; }

    }
}