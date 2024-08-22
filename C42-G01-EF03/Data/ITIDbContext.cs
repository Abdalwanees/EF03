using C42_G01_EF03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C42_G01_EF03.Models;
using Microsoft.EntityFrameworkCore;

namespace C42_G01_EF03.Data
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITI_DB3;Trusted_Connection=True;Encrypt=False");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course_Insts> Course_Insts { get; set; }
        public DbSet<Students_Course> Students_Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Topic-Course relationship (One-to-Many)
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Topic)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.TopicId)
                .OnDelete(DeleteBehavior.Restrict);

            // Department-Student relationship (One-to-Many)
            modelBuilder.Entity<Department>()
               .HasMany(d => d.Students)
               .WithOne(s => s.Department)
               .HasForeignKey(s => s.DeptId)
               .OnDelete(DeleteBehavior.Cascade);

            // Department-Instructor relationship (One-to-One)
            modelBuilder.Entity<Department>()
                .HasOne(d => d.Instructor)
                .WithMany()
                .HasForeignKey(d => d.InstructorId)
                .OnDelete(DeleteBehavior.Restrict);

            // Course-Instructor relationship (Many-to-Many)
            modelBuilder.Entity<Course_Insts>()
                .HasKey(ci => new { ci.CourseId, ci.InstructorId });

            modelBuilder.Entity<Course_Insts>()
                .HasOne(ci => ci.Course)
                .WithMany(c => c.Course_Insts)
                .HasForeignKey(ci => ci.CourseId);

            modelBuilder.Entity<Course_Insts>()
                .HasOne(ci => ci.Instructor)
                .WithMany(i => i.Course_Insts)
                .HasForeignKey(ci => ci.InstructorId);

            // Course-Student relationship (Many-to-Many)
            modelBuilder.Entity<Students_Course>()
                .HasKey(sc => new { sc.CourseId, sc.StudentId });

            modelBuilder.Entity<Students_Course>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.Students_Courses)
                .HasForeignKey(sc => sc.CourseId);

            modelBuilder.Entity<Students_Course>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.Students_Courses)
                .HasForeignKey(sc => sc.StudentId);
        }
    }
}
