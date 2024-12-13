using System.ComponentModel.DataAnnotations;

namespace PediatricsDepartment.Models
{
    public class EmergencyAlert
    {
        [Key]
        public int AlertID { get; set; }

        public required string Title { get; set; }

        public required string Message { get; set; }

        public required int HocaID { get; set; }
       
        [Required]
        public DateTime CreatedAt { get; set; }

        public Hoca? Hocalar { get; set; }
    }
}
