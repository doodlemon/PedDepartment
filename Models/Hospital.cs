using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PediatricsDepartment.Models
{
    public class Hospital
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public required string Name { get; set; }

        [MaxLength(300)]
        public required string Address { get; set; }

        [MaxLength(15)]
        public required string Phone { get; set; }

        public ICollection<Department>? Departments { get; set; }
    }
}
