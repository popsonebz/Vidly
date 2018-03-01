using System;

namespace Vidly.Models.Customers
               
{
    public class MembershipType
    {
        public byte Id {get; set;}
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

    }
}