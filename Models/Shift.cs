using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PediatricsDepartment.Models
{
    public class Shift
    {
        [Key]
        public int ShiftID { get; set; }
        public required int AssistantID { get; set; }
        public required int DepartmentID { get; set; }

        public required DateTime ShiftDate { get; set; }
        public required DateTime ShiftStart { get; set; }
        public required DateTime ShiftEnd { get; set; }

        public virtual Assistant? Assistants { get; set; }
        public virtual Department? Departments { get; set; }

        
    }

}