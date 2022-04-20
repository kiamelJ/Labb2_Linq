﻿// <auto-generated />
using System;
using DBManyToManyTest1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DBManyToManyTest1.Migrations
{
    [DbContext(typeof(ContextHandler))]
    partial class ContextHandlerModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DBManyToManyTest1.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "1A"
                        },
                        new
                        {
                            Id = 2,
                            Name = "1B"
                        },
                        new
                        {
                            Id = 3,
                            Name = "2A"
                        },
                        new
                        {
                            Id = 4,
                            Name = "2B"
                        },
                        new
                        {
                            Id = 5,
                            Name = "3A"
                        },
                        new
                        {
                            Id = 6,
                            Name = "3B"
                        });
                });

            modelBuilder.Entity("DBManyToManyTest1.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Programmering 1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Programmering 2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Programmering 3"
                        },
                        new
                        {
                            Id = 4,
                            Name = "OOP"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Databasteknik"
                        });
                });

            modelBuilder.Entity("DBManyToManyTest1.Models.Course_Students", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("Course_Students");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            StudentId = 1
                        },
                        new
                        {
                            CourseId = 1,
                            StudentId = 2
                        },
                        new
                        {
                            CourseId = 1,
                            StudentId = 3
                        },
                        new
                        {
                            CourseId = 2,
                            StudentId = 4
                        },
                        new
                        {
                            CourseId = 2,
                            StudentId = 5
                        },
                        new
                        {
                            CourseId = 2,
                            StudentId = 6
                        },
                        new
                        {
                            CourseId = 3,
                            StudentId = 7
                        },
                        new
                        {
                            CourseId = 3,
                            StudentId = 8
                        },
                        new
                        {
                            CourseId = 3,
                            StudentId = 9
                        },
                        new
                        {
                            CourseId = 4,
                            StudentId = 10
                        },
                        new
                        {
                            CourseId = 4,
                            StudentId = 11
                        },
                        new
                        {
                            CourseId = 4,
                            StudentId = 12
                        },
                        new
                        {
                            CourseId = 5,
                            StudentId = 13
                        },
                        new
                        {
                            CourseId = 5,
                            StudentId = 14
                        },
                        new
                        {
                            CourseId = 5,
                            StudentId = 15
                        });
                });

            modelBuilder.Entity("DBManyToManyTest1.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClassId = 1,
                            Name = "Alice"
                        },
                        new
                        {
                            Id = 2,
                            ClassId = 1,
                            Name = "Noah"
                        },
                        new
                        {
                            Id = 3,
                            ClassId = 1,
                            Name = "Maja"
                        },
                        new
                        {
                            Id = 4,
                            ClassId = 2,
                            Name = "William"
                        },
                        new
                        {
                            Id = 5,
                            ClassId = 2,
                            Name = "Elsa"
                        },
                        new
                        {
                            Id = 6,
                            ClassId = 2,
                            Name = "Hugo"
                        },
                        new
                        {
                            Id = 7,
                            ClassId = 3,
                            Name = "Astrid"
                        },
                        new
                        {
                            Id = 8,
                            ClassId = 3,
                            Name = "Lucas"
                        },
                        new
                        {
                            Id = 9,
                            ClassId = 3,
                            Name = "Wilma"
                        },
                        new
                        {
                            Id = 10,
                            ClassId = 4,
                            Name = "Liam"
                        },
                        new
                        {
                            Id = 11,
                            ClassId = 4,
                            Name = "Freja"
                        },
                        new
                        {
                            Id = 12,
                            ClassId = 4,
                            Name = "Oscar"
                        },
                        new
                        {
                            Id = 13,
                            ClassId = 5,
                            Name = "Olivia"
                        },
                        new
                        {
                            Id = 14,
                            ClassId = 5,
                            Name = "Oliver"
                        },
                        new
                        {
                            Id = 15,
                            ClassId = 6,
                            Name = "Selma"
                        });
                });

            modelBuilder.Entity("DBManyToManyTest1.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Anas"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Reidar"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Lena"
                        });
                });

            modelBuilder.Entity("DBManyToManyTest1.Models.Teacher_Classes", b =>
                {
                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.HasKey("TeacherId", "ClassId");

                    b.HasIndex("ClassId");

                    b.ToTable("Teacher_Classes");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            ClassId = 1
                        },
                        new
                        {
                            TeacherId = 1,
                            ClassId = 2
                        },
                        new
                        {
                            TeacherId = 2,
                            ClassId = 3
                        },
                        new
                        {
                            TeacherId = 2,
                            ClassId = 4
                        },
                        new
                        {
                            TeacherId = 3,
                            ClassId = 5
                        },
                        new
                        {
                            TeacherId = 3,
                            ClassId = 6
                        });
                });

            modelBuilder.Entity("DBManyToManyTest1.Models.Teacher_Courses", b =>
                {
                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("TeacherId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("Teacher_Courses");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            CourseId = 1
                        },
                        new
                        {
                            TeacherId = 2,
                            CourseId = 2
                        },
                        new
                        {
                            TeacherId = 1,
                            CourseId = 3
                        },
                        new
                        {
                            TeacherId = 3,
                            CourseId = 4
                        },
                        new
                        {
                            TeacherId = 3,
                            CourseId = 5
                        });
                });

            modelBuilder.Entity("DBManyToManyTest1.Models.Teacher_Students", b =>
                {
                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("TeacherId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("Teacher_Students");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            StudentId = 1
                        },
                        new
                        {
                            TeacherId = 1,
                            StudentId = 2
                        },
                        new
                        {
                            TeacherId = 1,
                            StudentId = 3
                        },
                        new
                        {
                            TeacherId = 2,
                            StudentId = 4
                        },
                        new
                        {
                            TeacherId = 2,
                            StudentId = 5
                        },
                        new
                        {
                            TeacherId = 2,
                            StudentId = 6
                        },
                        new
                        {
                            TeacherId = 1,
                            StudentId = 7
                        },
                        new
                        {
                            TeacherId = 1,
                            StudentId = 8
                        },
                        new
                        {
                            TeacherId = 1,
                            StudentId = 9
                        },
                        new
                        {
                            TeacherId = 3,
                            StudentId = 10
                        },
                        new
                        {
                            TeacherId = 3,
                            StudentId = 11
                        },
                        new
                        {
                            TeacherId = 3,
                            StudentId = 12
                        },
                        new
                        {
                            TeacherId = 3,
                            StudentId = 13
                        },
                        new
                        {
                            TeacherId = 3,
                            StudentId = 14
                        },
                        new
                        {
                            TeacherId = 3,
                            StudentId = 15
                        });
                });

            modelBuilder.Entity("DBManyToManyTest1.Models.Course_Students", b =>
                {
                    b.HasOne("DBManyToManyTest1.Models.Course", "Course")
                        .WithMany("Course_Students")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBManyToManyTest1.Models.Student", "Student")
                        .WithMany("Course_Students")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DBManyToManyTest1.Models.Student", b =>
                {
                    b.HasOne("DBManyToManyTest1.Models.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassId");
                });

            modelBuilder.Entity("DBManyToManyTest1.Models.Teacher_Classes", b =>
                {
                    b.HasOne("DBManyToManyTest1.Models.Class", "Class")
                        .WithMany("Teacher_Classes")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBManyToManyTest1.Models.Teacher", "Teacher")
                        .WithMany("Teacher_Classes")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DBManyToManyTest1.Models.Teacher_Courses", b =>
                {
                    b.HasOne("DBManyToManyTest1.Models.Course", "Course")
                        .WithMany("Teacher_Courses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBManyToManyTest1.Models.Teacher", "Teacher")
                        .WithMany("Teacher_Courses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DBManyToManyTest1.Models.Teacher_Students", b =>
                {
                    b.HasOne("DBManyToManyTest1.Models.Student", "Student")
                        .WithMany("Teacher_Students")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBManyToManyTest1.Models.Teacher", "Teacher")
                        .WithMany("Teacher_Students")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
