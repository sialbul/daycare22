using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace daycare22.Models
{
    public class Address
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "The field StreetAddress must not be blank.")]
        public string StreetAddress { get; set; }

        public string StreetAddress2 { get; set; }

        [Required(ErrorMessage = "The field City must not be blank.")]

        public string City { get; set; }

        [Required(ErrorMessage = "The field State must not be blank.")]

        public string State { get; set; }

        [Required(ErrorMessage = "The field Zip must not be blank.")]

        public string Zip { get; set; }

        public Address(string address, string address2, string city, string state, string zip)
        {
            Id = System.Guid.NewGuid().ToString();
            StreetAddress = address;
            StreetAddress2 = address2;
            City = city;
            State = state;
            Zip = zip;
        }
    }
}
