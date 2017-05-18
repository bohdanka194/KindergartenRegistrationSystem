using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.DAL.DTO
{
    public class KindergartenDTO
    {
        
        public int KindergartenId { get; set; }

        
        public int Number { get; set; }

        public string Description { get; set; }

        public int? AddressId { get; set; }


        

      //  public ICollection<Child> Сhildren { get; set; }

      //  public ICollection<Staff> Staves { get; set; }

        public AddressDTO Address { get; set; }

        public StaffDTO StaffDto { get; set; }
    }

   
}
