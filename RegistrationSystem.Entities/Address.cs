using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.Entities
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string Street { get; set; }

        public int House { get; set; }

        public int? Apartment { get; set; }

        public int? District { get; set; }

        public int? KindergartenId { get; set; }

        public int? ChildId { get; set; }

        
        public virtual ICollection<Child> Children { get; set; }

        
        public virtual ICollection<Kindergarten> Kindergartens { get; set; }
    }
}
