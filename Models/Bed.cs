using System.ComponentModel.DataAnnotations;

namespace PediatricsDepartment.Models
{
    public class Bed
    {
        [Key]
        public int BedID { get; set; }

        [Required]
        public int DepartmentID { get; set; } 
        public bool IsOccupied { get; set; } 
        public virtual Department? Departments { get; set; } 

    }
}
