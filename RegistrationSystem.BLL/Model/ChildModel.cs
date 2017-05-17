using RegistrationSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.Common.Model
{
    public class ChildModel
    {
        //public int Id { get; set; }
        private DateTime _date = DateTime.Now;
        public string FirstName { get; set; }

        public string LastName { get; set; }
     
        public string MiddleName { get; set; }

        public DateTime DateOfBirth
        {
            get { return _date; }
            set { _date = value; }
        }

        public string City { get; set; }

        public string Street { get; set; }

        public int House { get; set; }

        public int? Apartment { get; set; }

        public int? KindergartenId { get; set; }

        //public District? District { get; set; }


        public string Series { get; set; }


        public int Number { get; set; }


        public string Description { get; set; }

        public int KindergartenNumber { get; set; }

       
    }
}
