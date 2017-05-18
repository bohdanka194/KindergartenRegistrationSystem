using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.Common.Model
{
    public class KindergartenModel
    {
       

        public int Id { get; set; }

        
        public int Number { get; set; }

        
        public int AddressId { get; set; }

        public string Description { get; set; }

        public AddressModel AddressModel { get; set; }

        public StaffModel StaffModel { get; set; }


        //Navigation properties

        //public ICollection<Child> Сhildren { get; set; }
        //public ICollection<Group> Groups { get; set; }
        //public ICollection<Staff> Staves { get; set; }

        //[Required]
        //public Address Address { get; set; }
    }
}
