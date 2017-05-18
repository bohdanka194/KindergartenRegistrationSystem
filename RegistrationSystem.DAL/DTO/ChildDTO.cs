using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.DAL.DTO
{
    public class ChildDTO
    {
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public int House { get; set; }

        public int? Apartment { get; set; }

        public string Series { get; set; }


        public int Number { get; set; }

        public DateTime RegistrationTime { get; set; }
    }
}
