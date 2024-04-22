using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Labb_2___Linq.Models;

namespace Labb_2___Linq.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<SchoolClass> SchoolClasses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Enrollment>()
                .HasKey(e => e.EnrollmentId);  // primärnyckel

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Student) // Enrollment har en Student
                .WithMany(s => s.Enrollments) 
                .HasForeignKey(e => e.FkStudentId); // Främmande nyckel är StudentId

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Course) 
                .WithMany(c => c.Enrollments) 
                .HasForeignKey(e => e.FkCourseId); // Främmande nyckel är CourseId


            modelBuilder.Entity<Course>()
                .HasOne(c => c.Teacher) 
                .WithMany(t => t.Courses) 
                .HasForeignKey(c => c.TeacherId); // Främmande nyckel är TeacherId

            modelBuilder.Entity<Student>()
                .HasOne(s => s.SchoolClass) 
                .WithMany(sc => sc.Students) 
                .HasForeignKey(s => s.FKSchoolClassId); // Främmande nyckel är FKSchoolClassId
        }
    }
}
