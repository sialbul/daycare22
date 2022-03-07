using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace daycare22.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; }
        public string BirthDate { get; }
        public Address Address { get; set; }

        public string Image { get; }
        public string PhoneNumber { get; }





    }
}
