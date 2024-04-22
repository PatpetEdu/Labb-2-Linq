using System.ComponentModel.DataAnnotations;

namespace Labb_2___Linq.Models
{
    public class SchoolClass
    {
        [Key]
        public int SchoolClassId { get; set; }
        [Required]
        [StringLength(60, ErrorMessage = "Namnet får inte vara längre än 60 tecken")]
        [Display(Name = "Class Name")]
        public string ClassName { get; set; }
        public ICollection<Student>? Students { get; set; }
    }

}
