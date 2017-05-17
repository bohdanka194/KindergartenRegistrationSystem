using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.Entities
{
    public class Order
    {
        [ForeignKey("Child")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [Index("IX_UserIdAndChildId", 1, IsUnique = true)]
        public int UserId { get; set; }
        [Index("IX_UserIdAndChildId", 2, IsUnique = true)]
        public int ChildId { get; set; }

        [Required]
        public DateTime RegistrationTime { get; set; }

        public int KindergartenId { get; set; }

        public virtual Child Child { get; set; }

        public virtual User User { get; set; }
    }
}
