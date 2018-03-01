using System;

namespace Vidly.Models.Customers
               
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MembershipType MembershipType {get; set;} //this hepls to load both customer and membershiptype
        public byte MembershipTypeId {get; set;} // this is a foreign key from the membershiptype table

    }
}