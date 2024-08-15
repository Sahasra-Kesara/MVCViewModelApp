using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCViewModelApp.Models
{
    public class StudentCourseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [Display(Name = "Course")]
        public int CourseId { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
