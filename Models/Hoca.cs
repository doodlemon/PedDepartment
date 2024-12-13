using System.ComponentModel.DataAnnotations;

namespace PediatricsDepartment.Models
{
    public class Hoca
    {
        [Key]
        public int HocaID { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }

        [MaxLength(100)]
        public required string Email { get; set; }

        public int DepartmentID { get; set; }
        public virtual Department? Departments { get; set; }
        public virtual EmergencyAlert? Announcements{ get; set; }

    }
}
