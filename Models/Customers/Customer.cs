using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections.Generic;
namespace Vidly.Models.Customers
               
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate {get; set;}

        [Display(Name = "Membership Type")]
        public int MembershipTypeId {get; set;} // this is a foreign key from the membershiptype table
        public MembershipType MembershipType {get; set;} //this hepls to load both customer and membershiptype

    }
}