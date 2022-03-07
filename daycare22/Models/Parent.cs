using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace daycare22.Models
{
    public class Parent
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "The field parent name must not be blank.")]
        public string ParentName { get; }
        public string BirthDate { get; }

        [Required(ErrorMessage = "The field PhoneNumber must not be blank.")]
        public string PhoneNumber { get; }

        public Address Address { get; set; }

        public string EmailAddress { get; }
    }
}
