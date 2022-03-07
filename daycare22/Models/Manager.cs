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
    }
}
