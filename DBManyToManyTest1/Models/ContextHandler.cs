using DBManyToManyTest1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBManyToManyTest1
{
    public class ContextHandler : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Course> Courses { get; set; }


        //DbSet for joining table. Behövs det?
        public DbSet<Course_Students> Course_Students { get; set; }
        public DbSet<Teacher_Classes> Teacher_Classes { get; set; }
        public DbSet<Teacher_Courses> Teacher_Courses { get; set; }
        public DbSet<Teacher_Students> Teacher_Students { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API to create relations for binding tables
            modelBuilder.Entity<Course_Students>().HasKey(cs => new { cs.CourseId, cs.StudentId });
            modelBuilder.Entity<Teacher_Classes>().HasKey(tc => new { tc.TeacherId, tc.ClassId });
            modelBuilder.Entity<Teacher_Courses>().HasKey(tco => new { tco.TeacherId, tco.CourseId });
            modelBuilder.Entity<Teacher_Students>().HasKey(ts => new { ts.TeacherId, ts.StudentId });



            //Seed data to all tables
            modelBuilder.Entity<Teacher>()
                .HasData(
                new Teacher { Id = 1, Name = "Anas" },
                new Teacher { Id = 2, Name = "Reidar" },
                new Teacher { Id = 3, Name = "Lena" }
                );

            modelBuilder.Entity<Course>()
                .HasData(
                new Course { Id = 1, Name = "Programmering 1" },
                new Course { Id = 2, Name = "Programmering 2" },
                new Course { Id = 3, Name = "Programmering 3" },
                new Course { Id = 4, Name = "OOP" },
                new Course { Id = 5, Name = "Databasteknik" }
                );

            modelBuilder.Entity<Class>()
                .HasData(
                new Class { Id = 1, Name = "1A" },
                new Class { Id = 2, Name = "1B" },
                new Class { Id = 3, Name = "2A" },
                new Class { Id = 4, Name = "2B" },
                new Class { Id = 5, Name = "3A" },
                new Class { Id = 6, Name = "3B" }

                );

            modelBuilder.Entity<Student>()
                .HasData(
                new { Id = 1, Name = "Alice", ClassId = 1 },
                new { Id = 2, Name = "Noah", ClassId = 1 },
                new { Id = 3, Name = "Maja", ClassId = 1 },
                new { Id = 4, Name = "William", ClassId = 2 },
                new { Id = 5, Name = "Elsa", ClassId = 2 },
                new { Id = 6, Name = "Hugo", ClassId = 2 },
                new { Id = 7, Name = "Astrid", ClassId = 3 },
                new { Id = 8, Name = "Lucas", ClassId = 3 },
                new { Id = 9, Name = "Wilma", ClassId = 3 },
                new { Id = 10, Name = "Liam", ClassId = 4 },
                new { Id = 11, Name = "Freja", ClassId = 4 },
                new { Id = 12, Name = "Oscar", ClassId = 4 },
                new { Id = 13, Name = "Olivia", ClassId = 5 },
                new { Id = 14, Name = "Oliver", ClassId = 5 },
                new { Id = 15, Name = "Selma", ClassId = 6 }
                );

            modelBuilder.Entity<Teacher_Classes>()
                .HasData(
                new Teacher_Classes {  TeacherId= 1, ClassId = 1 },
                new Teacher_Classes {  TeacherId= 1, ClassId = 2 },
                new Teacher_Classes {  TeacherId= 2, ClassId = 3 },
                new Teacher_Classes {  TeacherId= 2, ClassId = 4 },
                new Teacher_Classes {  TeacherId= 3, ClassId = 5 },
                new Teacher_Classes {  TeacherId= 3, ClassId = 6 }
                );

            modelBuilder.Entity<Teacher_Courses>()
                .HasData(
                new Teacher_Courses { TeacherId = 1, CourseId = 1 },
                new Teacher_Courses { TeacherId = 2, CourseId = 2 },
                new Teacher_Courses { TeacherId = 1, CourseId = 3 },
                new Teacher_Courses { TeacherId = 3, CourseId = 4 },
                new Teacher_Courses { TeacherId = 3, CourseId = 5 }
                );

            modelBuilder.Entity<Teacher_Students>()
                .HasData(
                new Teacher_Students { TeacherId = 1, StudentId = 1 },
                new Teacher_Students { TeacherId = 1, StudentId = 2 },
                new Teacher_Students { TeacherId = 1, StudentId = 3 },
                new Teacher_Students { TeacherId = 2, StudentId = 4 },
                new Teacher_Students { TeacherId = 2, StudentId = 5 },
                new Teacher_Students { TeacherId = 2, StudentId = 6 },
                new Teacher_Students { TeacherId = 1, StudentId = 7 },
                new Teacher_Students { TeacherId = 1, StudentId = 8 },
                new Teacher_Students { TeacherId = 1, StudentId = 9 },
                new Teacher_Students { TeacherId = 3, StudentId = 10 },
                new Teacher_Students { TeacherId = 3, StudentId = 11 },
                new Teacher_Students { TeacherId = 3, StudentId = 12 },
                new Teacher_Students { TeacherId = 3, StudentId = 13 },
                new Teacher_Students { TeacherId = 3, StudentId = 14 },
                new Teacher_Students { TeacherId = 3, StudentId = 15 }
                );

            modelBuilder.Entity<Course_Students>()
                .HasData(
                new Course_Students { CourseId = 1, StudentId = 1 },
                new Course_Students { CourseId = 1, StudentId = 2 },
                new Course_Students { CourseId = 1, StudentId = 3 },
                new Course_Students { CourseId = 2, StudentId = 4 },
                new Course_Students { CourseId = 2, StudentId = 5 },
                new Course_Students { CourseId = 2, StudentId = 6 },
                new Course_Students { CourseId = 3, StudentId = 7 },
                new Course_Students { CourseId = 3, StudentId = 8 },
                new Course_Students { CourseId = 3, StudentId = 9 },
                new Course_Students { CourseId = 4, StudentId = 10 },
                new Course_Students { CourseId = 4, StudentId = 11 },
                new Course_Students { CourseId = 4, StudentId = 12 },
                new Course_Students { CourseId = 5, StudentId = 13 },
                new Course_Students { CourseId = 5, StudentId = 14 },
                new Course_Students { CourseId = 5, StudentId = 15 }
                );
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=.\sqlexpress; initial catalog=DBManyToManyTest1Core; integrated security=sspi;");
        }
    }
}
