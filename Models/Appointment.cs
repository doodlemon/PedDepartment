using System.ComponentModel.DataAnnotations;

namespace PediatricsDepartment.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentID { get; set; }

        [Required]
        public required int AssistantID { get; set; } 

        [Required]
        public int TeacherID { get; set; } 
      
        [Required]
        public DateTime AppointmentDate { get; set; }

        public virtual Department? Departments { get; set; }

    }
}
