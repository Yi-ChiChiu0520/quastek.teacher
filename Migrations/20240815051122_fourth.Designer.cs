﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using quasitekWeb.Data;

#nullable disable

namespace quasitekWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240815051122_fourth")]
    partial class fourth
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.7.23375.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("quasitekWeb.Models.Classes", b =>
                {
                    b.Property<long>("ClassesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ClassesId"));

                    b.Property<string>("ClassesCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClassesName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CourseId")
                        .HasColumnType("bigint");

                    b.Property<int>("StudentAmount")
                        .HasColumnType("int");

                    b.Property<long>("TeacherId")
                        .HasColumnType("bigint");

                    b.HasKey("ClassesId");

                    b.HasIndex("CourseId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("quasitekWeb.Models.Course", b =>
                {
                    b.Property<long>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CourseId"));

                    b.Property<string>("CourseIntro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxScore")
                        .HasColumnType("int");

                    b.Property<int>("MaxTime")
                        .HasColumnType("int");

                    b.Property<string>("Mode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionNum")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("quasitekWeb.Models.Device", b =>
                {
                    b.Property<int>("DeviceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeviceId"));

                    b.Property<string>("DeviceModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExpireDate")
                        .HasColumnType("int");

                    b.Property<int>("PurchaseDate")
                        .HasColumnType("int");

                    b.HasKey("DeviceId");

                    b.ToTable("Device");
                });

            modelBuilder.Entity("quasitekWeb.Models.Record", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecordId"));

                    b.Property<long>("ClassesId")
                        .HasColumnType("bigint");

                    b.Property<long>("CourseId")
                        .HasColumnType("bigint");

                    b.Property<string>("Mode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionNum")
                        .HasColumnType("int");

                    b.Property<DateTime>("RecordDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("StudentId")
                        .HasColumnType("bigint");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TestScore")
                        .HasColumnType("int");

                    b.Property<int>("TestTime")
                        .HasColumnType("int");

                    b.HasKey("RecordId");

                    b.HasIndex("ClassesId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Record");
                });

            modelBuilder.Entity("quasitekWeb.Models.Student", b =>
                {
                    b.Property<long>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("StudentId"));

                    b.Property<long>("ClassesId")
                        .HasColumnType("bigint");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.HasIndex("ClassesId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("quasitekWeb.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"));

                    b.Property<string>("Authorize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pw")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("quasitekWeb.Models.Classes", b =>
                {
                    b.HasOne("quasitekWeb.Models.Course", "Course")
                        .WithMany("Classes")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("quasitekWeb.Models.Record", b =>
                {
                    b.HasOne("quasitekWeb.Models.Classes", "Classes")
                        .WithMany("Record")
                        .HasForeignKey("ClassesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("quasitekWeb.Models.Course", "Course")
                        .WithMany("Record")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("quasitekWeb.Models.Student", "Student")
                        .WithMany("Record")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classes");

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("quasitekWeb.Models.Student", b =>
                {
                    b.HasOne("quasitekWeb.Models.Classes", "Classes")
                        .WithMany("Students")
                        .HasForeignKey("ClassesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classes");
                });

            modelBuilder.Entity("quasitekWeb.Models.Classes", b =>
                {
                    b.Navigation("Record");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("quasitekWeb.Models.Course", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("Record");
                });

            modelBuilder.Entity("quasitekWeb.Models.Student", b =>
                {
                    b.Navigation("Record");
                });
#pragma warning restore 612, 618
        }
    }
}
