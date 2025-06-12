using System.ComponentModel.DataAnnotations;

namespace API_Day1.Models
{
    public class Course
    {
        [Key]
        public int Id{ get; set; }
        [Required(ErrorMessage = "Course name is required.")]
        [MaxLength(50, ErrorMessage ="MAX Course length is 50")]
        public string Crs_Name { get; set; }

        [MaxLength(150, ErrorMessage = "MAX Course length is 150")]
        public string? Crs_Description { get; set; }
        [Required(ErrorMessage ="Duration is required")]
        public int Duration { get; set; }
    }
}
