using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.Entities
{
    public class Child
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string MiddleName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int AddressId { get; set; }

        public int KindergartenId { get; set; }

        //navigation

        public virtual Address Address { get; set; }

        //[Required]
        public virtual BirthCertificate BirthCertificate { get; set; }

        public virtual Kindergarten Kindergarten { get; set; }

        public virtual User User { get; set; }

        //public virtual Order Order { get; set; }
    }
}
