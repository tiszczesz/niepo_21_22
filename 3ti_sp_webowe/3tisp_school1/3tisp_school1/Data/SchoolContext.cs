using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _3tisp_school1.Models;
using Microsoft.EntityFrameworkCore;

namespace _3tisp_school1.Data
{
    public class SchoolContext: DbContext {
        public SchoolContext(DbContextOptions<SchoolContext> options)
            :base(options)
        { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                new Student {
                    IdStudentId = 1,StudentName = "Roman",DateOfBirth = new DateTime(2000, 1, 12),
                    Height = 178M, Weight = 89.9f,GradeId = 5//dodac Grade
                },
                new Student
                {
                    IdStudentId = 2,
                    DateOfBirth = new DateTime(2005, 1, 12),
                    Height = 178M,
                    StudentName = "Monika",
                    Weight = 89.9f,//dodac Grade
                    GradeId = 2
                },
                new Student
                {
                    IdStudentId = 3,
                    DateOfBirth = new DateTime(2007, 2, 11),
                    Height = 178M,
                    StudentName = "Tomasz",
                    Weight = 89.9f,//dodac Grade
                    GradeId = 3
                },
                new Student
                {
                    IdStudentId = 4,
                    DateOfBirth = new DateTime(1999, 6, 7),
                    Height = 178M,
                    StudentName = "Urszula",
                    Weight = 89.9f,//dodac Grade
                    GradeId = 1
                }
            );
            modelBuilder.Entity<Grade>().HasData(
                new Grade{GradeId = 1,GradeName = "celujący",Section = "Informatyka"},
                new Grade{GradeId = 2,GradeName = "dobry",Section = "Informatyka"},
                new Grade{GradeId = 3,GradeName = "dostateczny",Section = "Informatyka"},
                new Grade{GradeId = 4,GradeName = "bardzo dobry",Section = "Informatyka"},
                new Grade{GradeId = 5,GradeName = "dopuszczający",Section = "Informatyka"},
                new Grade{GradeId = 6,GradeName = "niedostateczny",Section = "Informatyka"}
            );
        }
    }
}
