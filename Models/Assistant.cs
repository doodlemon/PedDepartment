using System.ComponentModel.DataAnnotations; // You put this to use [Key]

namespace PediatricsDepartment.Models
{
    public class Assistant
    {
        [Key]
        public int AssistantID { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public ICollection<Shift>? Shifts { get; set; } 
        
    }
}
