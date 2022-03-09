using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace daycare22.Models
{
    public class EmergencyContact
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "The field Name must not be blank.")]
        public string Name { get; }

        [Required(ErrorMessage = "The field PhoneNumber must not be blank.")]
        public string PhoneNumber { get; }

        }
}
