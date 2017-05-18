using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.Entities
{
    public class Kindergarten
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KindergartenId { get; set; }

        
        [Index(IsUnique = true)]
        public int Number { get; set; }

        public string Description { get; set; }

        public int? AddressId { get; set; }

        public virtual Address Address { get; set; }

        
        public virtual ICollection<Child> Children { get; set; }

        
        public virtual ICollection<Staff> Staves { get; set; }
    }
}
