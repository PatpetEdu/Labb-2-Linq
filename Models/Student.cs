using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Labb_2___Linq.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        [StringLength(60, ErrorMessage = "Namnet får inte vara längre än 60 tecken")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [StringLength(60, ErrorMessage = "Namnet får inte vara längre än 60 tecken")]
        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [ForeignKey("SchoolClass")]
        public int FKSchoolClassId { get; set; }
        public SchoolClass? SchoolClass { get; set; }
        public ICollection<Enrollment>? Enrollments { get; set; }
    }

}
