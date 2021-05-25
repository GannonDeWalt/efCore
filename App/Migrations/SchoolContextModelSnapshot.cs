﻿// <auto-generated />
using App;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.Migrations
{
    [DbContext(typeof(SchoolContext))]
    partial class SchoolContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("App.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CourseName")
                        .HasColumnType("TEXT");

                    b.Property<float>("GradeP")
                        .HasColumnType("REAL");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Grades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseName = "Spanish",
                            GradeP = 20f,
                            StudentId = 1
                        },
                        new
                        {
                            Id = 2,
                            CourseName = "Geometry",
                            GradeP = 90f,
                            StudentId = 2
                        },
                        new
                        {
                            Id = 3,
                            CourseName = "Mathematics",
                            GradeP = 25f,
                            StudentId = 3
                        },
                        new
                        {
                            Id = 4,
                            CourseName = "Mathematics",
                            GradeP = 75f,
                            StudentId = 1
                        },
                        new
                        {
                            Id = 5,
                            CourseName = "Mathematics",
                            GradeP = 85f,
                            StudentId = 2
                        },
                        new
                        {
                            Id = 6,
                            CourseName = "Geometry",
                            GradeP = 75f,
                            StudentId = 3
                        },
                        new
                        {
                            Id = 7,
                            CourseName = "Venting",
                            GradeP = 55f,
                            StudentId = 2
                        });
                });

            modelBuilder.Entity("App.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<int>("classification")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 16,
                            FirstName = "Pickle",
                            LastName = "Rick",
                            classification = 0
                        },
                        new
                        {
                            Id = 2,
                            Age = 14,
                            FirstName = "Rick",
                            LastName = "Sanchez",
                            classification = 1
                        },
                        new
                        {
                            Id = 3,
                            Age = 17,
                            FirstName = "Tom",
                            LastName = "Hanks",
                            classification = 2
                        },
                        new
                        {
                            Id = 4,
                            Age = 5,
                            FirstName = "Sussy",
                            LastName = "Backa",
                            classification = 3
                        });
                });

            modelBuilder.Entity("App.Grade", b =>
                {
                    b.HasOne("App.Student", "student")
                        .WithMany("grades")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("student");
                });

            modelBuilder.Entity("App.Student", b =>
                {
                    b.Navigation("grades");
                });
#pragma warning restore 612, 618
        }
    }
}
