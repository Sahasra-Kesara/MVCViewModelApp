namespace MVCViewModelApp.Models
{
    public class StudentCourseEnrollment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
