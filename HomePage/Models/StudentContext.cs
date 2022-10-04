using Microsoft.EntityFrameworkCore;

namespace HomePage.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        { }

        public DbSet<StudentModel> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<StudentModel>().HasData(
                new StudentModel
                {
                    StudentId = 1,
                    FirstName = "Morgan",
                    LastName = "Christensen",
                    Grade = "A-"
                },
                new StudentModel
                {
                    StudentId = 2,
                    FirstName = "Adam",
                    LastName = "Warlock",
                    Grade = "B+"
                },
                new StudentModel
                {
                    StudentId = 3,
                    FirstName = "Daniel",
                    LastName = "Thrasher",
                    Grade = "C"
                },
                new StudentModel
                {
                    StudentId = 4,
                    FirstName = "John",
                    LastName = "Snow",
                    Grade = "B-"
                },
                new StudentModel
                {
                    StudentId = 5,
                    FirstName = "Christine",
                    LastName = "Adams",
                    Grade = "A"
                }
            );
        }
    }
}
