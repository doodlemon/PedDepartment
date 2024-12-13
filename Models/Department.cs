using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PediatricsDepartment.Models
{
    public class Department
    {
        [Key] 

        public int DepartmentID { get; set; }

        public required string Name { get; set; }
        public string? Description { get; set; }

        public int TotalBeds { get; set; } 
        public int EmptyBeds { get; set; } 

        public ICollection<Shift>? Shifts { get; set; }
        public ICollection<Hoca>? Hocalar { get; set; }
        public ICollection<Bed>? Beds { get; set; } 
        public virtual Hospital? Hospitals { get; set; }
        public ICollection<Appointment>? Appointments{ get; set; }
    }
}
