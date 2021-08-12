﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cv8_mvc;

namespace cv8_mvc.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210414103329_ChangeOneToOne-To-OneToMany-StudentCourse")]
    partial class ChangeOneToOneToOneToManyStudentCourse
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("cv8_mvc.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CourseName")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("CourseNameAbbreviation")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(2000)
                        .HasColumnType("TEXT");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            CourseNameAbbreviation = "PAPR4"
                        },
                        new
                        {
                            CourseId = 2,
                            CourseNameAbbreviation = "DATA1"
                        },
                        new
                        {
                            CourseId = 3,
                            CourseNameAbbreviation = "OS1"
                        });
                });

            modelBuilder.Entity("cv8_mvc.Models.CourseStatute", b =>
                {
                    b.Property<int>("CourseStatuteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .HasMaxLength(1)
                        .HasColumnType("TEXT");

                    b.HasKey("CourseStatuteId");

                    b.ToTable("CourseStatutes");

                    b.HasData(
                        new
                        {
                            CourseStatuteId = 1,
                            Value = "A"
                        },
                        new
                        {
                            CourseStatuteId = 2,
                            Value = "B"
                        },
                        new
                        {
                            CourseStatuteId = 3,
                            Value = "C"
                        });
                });

            modelBuilder.Entity("cv8_mvc.Models.Grade", b =>
                {
                    b.Property<int>("GradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .HasMaxLength(1)
                        .HasColumnType("TEXT");

                    b.HasKey("GradeId");

                    b.ToTable("Grades");

                    b.HasData(
                        new
                        {
                            GradeId = 1,
                            Value = "A"
                        },
                        new
                        {
                            GradeId = 2,
                            Value = "B"
                        },
                        new
                        {
                            GradeId = 3,
                            Value = "C"
                        },
                        new
                        {
                            GradeId = 4,
                            Value = "D"
                        },
                        new
                        {
                            GradeId = 5,
                            Value = "E"
                        },
                        new
                        {
                            GradeId = 6,
                            Value = "F"
                        },
                        new
                        {
                            GradeId = 7,
                            Value = "-"
                        });
                });

            modelBuilder.Entity("cv8_mvc.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CardNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Faculty")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasMaxLength(1)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonalNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Specialization")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudyForm")
                        .HasMaxLength(1)
                        .HasColumnType("TEXT");

                    b.Property<string>("StudyProgramCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudyProgramName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasMaxLength(8)
                        .HasColumnType("TEXT");

                    b.Property<int?>("YearOfStudy")
                        .HasColumnType("INTEGER");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            CardNumber = "0C993347",
                            Email = "bercon00@prfnw.upol.cz",
                            Faculty = "PRF",
                            FirstName = "Ondřej",
                            Gender = "M",
                            LastName = "BERČÍK",
                            PersonalNumber = "R19118",
                            Specialization = "INF",
                            StudyForm = "P",
                            StudyProgramCode = "B0613A140009",
                            StudyProgramName = "Informatika",
                            UserName = "bercon00",
                            YearOfStudy = 2
                        },
                        new
                        {
                            StudentId = 2,
                            CardNumber = "AC0EBBE9",
                            Email = "bezdmi01@prfnw.upol.cz",
                            Faculty = "PRF",
                            FirstName = "Michal",
                            Gender = "M",
                            LastName = "BEZDĚK",
                            PersonalNumber = "R19705",
                            Specialization = "APLINF",
                            StudyForm = "P",
                            StudyProgramCode = "B0613A140008",
                            StudyProgramName = "Aplikovaná informatika",
                            UserName = "bezdmi01",
                            YearOfStudy = 2
                        });
                });

            modelBuilder.Entity("cv8_mvc.Models.StudentCourse", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseStatuteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GradeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.HasIndex("CourseStatuteId");

                    b.HasIndex("GradeId");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("cv8_mvc.Models.StudentCourse", b =>
                {
                    b.HasOne("cv8_mvc.Models.Course", "Course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cv8_mvc.Models.CourseStatute", "CourseStatute")
                        .WithMany("StudentCourse")
                        .HasForeignKey("CourseStatuteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cv8_mvc.Models.Grade", "StudentGrade")
                        .WithMany("StudentCourse")
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cv8_mvc.Models.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("CourseStatute");

                    b.Navigation("Student");

                    b.Navigation("StudentGrade");
                });

            modelBuilder.Entity("cv8_mvc.Models.Course", b =>
                {
                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("cv8_mvc.Models.CourseStatute", b =>
                {
                    b.Navigation("StudentCourse");
                });

            modelBuilder.Entity("cv8_mvc.Models.Grade", b =>
                {
                    b.Navigation("StudentCourse");
                });

            modelBuilder.Entity("cv8_mvc.Models.Student", b =>
                {
                    b.Navigation("StudentCourses");
                });
#pragma warning restore 612, 618
        }
    }
}
