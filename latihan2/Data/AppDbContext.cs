using Microsoft.EntityFrameworkCore;
using latihan2.Models;

namespace latihan2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "Gan", Email = "gan@gmail.com", Age = 30},
                new Student { Id = 2, Name = "Zidan", Email = "zidan@gmail.com", Age = 25 },
                new Student { Id = 3, Name = "Tedi", Email = "tedi@gmail.com", Age = 24 }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Title = "Pemrograman C#", StudentId = 1 },
                new Course { Id = 2, Title = "Pemrograman Java", StudentId = 1 },
                new Course { Id = 3, Title = "Pemrograman Python", StudentId = 2 },
                new Course { Id = 4, Title = "Pemrograman PHP", StudentId = 3 }
            );
            // modelBuilder.Entity<Student>().ToTable("Students");
            // modelBuilder.Entity<Course>().ToTable("Courses");
        }
    }
}