using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace daycare22.Models
{
    public class Manager
    {

        public int Id { get; set; }
        public string ManagerName { get; }
        public string BirthDate { get; }

        public string PhoneNumber { get; }
        public Address Address { get; set; }

        public string EmailAddress { get; }

        public Manager(int id, string name, string birthDate, Address address, string emailAddress, string phoneNumber)
        {
            Id = id;
            ManagerName = name;
            BirthDate = birthDate;
            Address = address;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
        }



    }
}
