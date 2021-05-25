using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace App {
    public class SchoolContext : DbContext
    {
        public DbSet<Grade> Grades {get; set;}
        public DbSet<Student> Students {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=SchoolDB.db;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student[] {
            new Student { Id = 1, FirstName = "Pickle", LastName = "Rick", Age = 16, classification = Classification.Freshman},
            new Student { Id = 5, FirstName = "Minecraft", LastName = "Steve", Age = 12, classification = Classification.Freshman},
            new Student { Id = 2, FirstName = "Rick", LastName = "Sanchez", Age = 14, classification = Classification.Sophomore },
            new Student { Id = 6, FirstName = "Harambe", LastName = "Gorilla", Age = 14, classification = Classification.Sophomore },
            new Student { Id = 7, FirstName = "Doug", LastName = "Dimmadome", Age = 14, classification = Classification.Sophomore },
            new Student { Id = 3, FirstName = "Tom", LastName = "Hanks", Age = 17, classification = Classification.Junior },
            new Student { Id = 4, FirstName = "Sussy", LastName = "Backa", Age = 5, classification = Classification.Senior },
            });

            modelBuilder.Entity<Grade>().HasData(new Grade[] { 
            new Grade { Id = 1, StudentId = 1, CourseName= "Spanish", GradeP = 20.0F },
            new Grade { Id = 2, StudentId = 2, CourseName = "Geometry", GradeP = 90.0F },
            new Grade { Id = 3, StudentId = 3, CourseName= "Mathematics", GradeP = 25.0F },
            new Grade {Id = 4, StudentId = 1, CourseName= "Mathematics", GradeP = 75.0F },
            new Grade {Id = 5, StudentId = 2, CourseName= "Mathematics", GradeP = 85.0F },
            new Grade {Id = 6, StudentId = 3, CourseName= "Geometry", GradeP = 75.0F },
            new Grade {Id = 7, StudentId = 6, CourseName= "Venting", GradeP = 100.0F },
            new Grade {Id = 8, StudentId = 6, CourseName= "Geometry", GradeP = 55.0F },
            new Grade {Id = 9, StudentId = 7, CourseName= "Venting", GradeP = 40.0F },
            new Grade {Id = 10, StudentId = 7, CourseName= "Mathematics", GradeP = 75.0F },
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}