using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Labb_2___Linq.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        [StringLength(60, ErrorMessage = "Namnet får inte vara längre än 60 tecken")]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public ICollection<Enrollment>? Enrollments { get; set; }
    }

}
