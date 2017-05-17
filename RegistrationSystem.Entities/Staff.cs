using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.Entities
{
    public class Staff
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StaffId { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public int? StaffPositionId { get; set; }

        public int? KindergartenId { get; set; }

        public virtual Kindergarten Kindergarten { get; set; }

        public virtual StaffPosition StaffPosition { get; set; }
    }
}
