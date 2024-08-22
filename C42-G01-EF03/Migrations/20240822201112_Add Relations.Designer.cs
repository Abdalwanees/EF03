﻿// <auto-generated />
using System;
using C42_G01_EF03.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace C42_G01_EF03.Migrations
{
    [DbContext(typeof(ITIDbContext))]
    [Migration("20240822201112_Add Relations")]
    partial class AddRelations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("C42_G01_EF03.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TopicId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("C42_G01_EF03.Models.Course_Insts", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("Evaluate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId", "InstructorId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Course_Insts");
                });

            modelBuilder.Entity("C42_G01_EF03.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("HiringDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<int?>("InstructorId1")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.HasIndex("InstructorId1")
                        .IsUnique()
                        .HasFilter("[InstructorId1] IS NOT NULL");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("C42_G01_EF03.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Bouns")
                        .HasColumnType("int");

                    b.Property<double>("HourlyRate")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("C42_G01_EF03.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("DeptId")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DeptId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("C42_G01_EF03.Models.Students_Course", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("Students_Courses");
                });

            modelBuilder.Entity("C42_G01_EF03.Models.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("C42_G01_EF03.Models.Course", b =>
                {
                    b.HasOne("C42_G01_EF03.Models.Topic", "Topic")
                        .WithMany("Courses")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("C42_G01_EF03.Models.Course_Insts", b =>
                {
                    b.HasOne("C42_G01_EF03.Models.Course", "Course")
                        .WithMany("Course_Insts")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("C42_G01_EF03.Models.Instructor", "Instructor")
                        .WithMany("Course_Insts")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("C42_G01_EF03.Models.Department", b =>
                {
                    b.HasOne("C42_G01_EF03.Models.Instructor", "Instructor")
                        .WithMany()
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("C42_G01_EF03.Models.Instructor", null)
                        .WithOne("Department")
                        .HasForeignKey("C42_G01_EF03.Models.Department", "InstructorId1");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("C42_G01_EF03.Models.Student", b =>
                {
                    b.HasOne("C42_G01_EF03.Models.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("C42_G01_EF03.Models.Students_Course", b =>
                {
                    b.HasOne("C42_G01_EF03.Models.Course", "Course")
                        .WithMany("Students_Courses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("C42_G01_EF03.Models.Student", "Student")
                        .WithMany("Students_Courses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("C42_G01_EF03.Models.Course", b =>
                {
                    b.Navigation("Course_Insts");

                    b.Navigation("Students_Courses");
                });

            modelBuilder.Entity("C42_G01_EF03.Models.Department", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("C42_G01_EF03.Models.Instructor", b =>
                {
                    b.Navigation("Course_Insts");

                    b.Navigation("Department")
                        .IsRequired();
                });

            modelBuilder.Entity("C42_G01_EF03.Models.Student", b =>
                {
                    b.Navigation("Students_Courses");
                });

            modelBuilder.Entity("C42_G01_EF03.Models.Topic", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
