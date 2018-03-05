using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections.Generic;
namespace Vidly.DTO
               
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public DateTime? Birthdate {get; set;}

        public int MembershipTypeId {get; set;} // this is a foreign key from the membershiptype table
        //public MembershipType MembershipType {get; set;} //this hepls to load both customer and membershiptype

    }
}