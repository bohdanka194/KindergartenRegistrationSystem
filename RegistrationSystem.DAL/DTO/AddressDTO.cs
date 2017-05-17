using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.DAL.DTO
{
    public class AddressDTO
    {
        
        public int AddressId { get; set; }

        
        public string City { get; set; }

        
        public string Street { get; set; }

        
        public int House { get; set; }

        public int? Apartment { get; set; }

    //    public District? District { get; set; }

        public int? KindergartenId { get; set; }

        public int? ChildId { get; set; }


        //Navigation properties
     //   public virtual ICollection<Child> Сhildren { get; set; }

     //   public ICollection<Kindergarten> Kindergarten { get; set; }
    }
}
