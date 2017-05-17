using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.Entities
{
    public class StaffPosition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StaffPositionId { get; set; }

        [Required]
        [StringLength(50)]
        [Index(IsUnique = true)]
        public string PositionName { get; set; }

        
        public virtual ICollection<Staff> Staves { get; set; }
    }
}
