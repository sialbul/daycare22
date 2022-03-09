using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace daycare22.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field student name must not be blank.")]
        public string StudentName { get; }

        [Required(ErrorMessage = "The field BirthDate must not be blank.")]
        public string BirthDate { get; }

        public Address Address { get; set; }

        public string Image { get; }

        [Required(ErrorMessage = "The field PhoneNumber must not be blank.")]
        public string PhoneNumber { get; }

        public Student(int id, string name,string birthDate, Address address, string image, string phoneNumber)
        {
            Id = id;
            StudentName = name;
            BirthDate = birthDate;
            Address = address;
            Image = image;
            PhoneNumber = phoneNumber;
        }

    }
}
