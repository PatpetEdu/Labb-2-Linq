using System.ComponentModel.DataAnnotations;

namespace Labb_2___Linq.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        [StringLength(60, ErrorMessage = "Namnet får inte vara längre än 60 tecken")]
        [Display(Name = "First name")]
        public string? FirstName { get; set; }
        [StringLength(60, ErrorMessage = "Namnet får inte vara längre än 60 tecken")]
        [Display(Name = "Last name")]
        public string? LastName { get; set; }
        public ICollection<Course>? Courses { get; set; }
    }
}
