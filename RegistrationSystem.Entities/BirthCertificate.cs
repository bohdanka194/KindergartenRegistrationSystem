using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.Entities
{
    public class BirthCertificate
    {
        
        [Key, ForeignKey("Child")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BirthCertificateId { get; set; }

        [Required]
        [StringLength(4)]
        public string Series { get; set; }

        public int Number { get; set; }

        [Required]
        [StringLength(400)]
        public string Description { get; set; }
        
        [Required]
        public virtual Child Child { get; set; }
    }
}
