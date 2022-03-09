using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace daycare22.Models
{
    public class Teacher
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "The field name must not be blank.")]
        public string TeacherName { get; }

        public string BirthDate { get; }

        [Required(ErrorMessage = "The field PhoneNumber must not be blank.")]
        public string PhoneNumber { get; }

        public Address Address { get; set; }

        public string EmailAddress { get; }


        public Teacher(int id, string name, string birthDate, Address address, string emailAddress, string phoneNumber)
        {
            Id = id;
            TeacherName = name;
            BirthDate = birthDate;
            Address = address;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
        }

    }
}
