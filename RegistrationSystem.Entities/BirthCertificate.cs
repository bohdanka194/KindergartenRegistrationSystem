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
        
        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(4)]
        public string Series { get; set; }

        public int Number { get; set; }

        [Required]
        [StringLength(400)]
        public string Description { get; set; }

        public virtual Child Child { get; set; }
    }
}
