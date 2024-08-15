using Microsoft.EntityFrameworkCore;

namespace MVCViewModelApp.Models
{
    public class InstituteDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourseEnrollment> StudentCourseEnrollments { get; set; }
        public InstituteDbContext(DbContextOptions<InstituteDbContext> options) 
            : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=InstituteDb;Trusted_Connection=True;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
