﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SMS.Infrastructure.Context;

#nullable disable

namespace SMS.Infrastructure.Migrations
{
    [DbContext(typeof(SMSDBContext))]
    [Migration("20240701052409_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SMS.Infrastructure.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LandMark")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .IsFixedLength();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Pincode")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.AdmitCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.HasIndex("StudentId");

                    b.ToTable("AdmitCards");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Year")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Class_1",
                            Year = new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Name = "Class_2",
                            Year = new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Name = "Class_3",
                            Year = new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.ClassStudent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("StudentId");

                    b.ToTable("ClassStudents");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.Fee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("date");

                    b.Property<decimal>("FeeAmount")
                        .HasColumnType("decimal(18,0)");

                    b.Property<DateTime?>("PaidDate")
                        .HasColumnType("date");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Fees");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.Notice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("PostedOn")
                        .HasColumnType("datetime");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Notices");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.Parent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime")
                        .HasColumnName("DOB");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("LastLoginDate")
                        .HasColumnType("datetime");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.Result", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<decimal>("Marks")
                        .HasColumnType("decimal(18,0)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<DateTime>("DateOfJoin")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime")
                        .HasColumnName("DOB");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsEmailVerified")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastLoginDate")
                        .HasColumnType("datetime");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .IsFixedLength();

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("ParentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "This is a english subject",
                            Grade = 100,
                            SubjectName = "English"
                        },
                        new
                        {
                            Id = 2,
                            Description = "This is a Physics subject",
                            Grade = 100,
                            SubjectName = "Physics"
                        },
                        new
                        {
                            Id = 3,
                            Description = "This is a Hindi subject",
                            Grade = 100,
                            SubjectName = "Hindi"
                        },
                        new
                        {
                            Id = 4,
                            Description = "This is a Geography subject",
                            Grade = 100,
                            SubjectName = "Geography"
                        });
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<DateTime>("DateOfJoin")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime")
                        .HasColumnName("DOB");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("LastLoginDate")
                        .HasColumnType("datetime");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .IsFixedLength();

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("SubjectId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.TimeTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("SubjectId");

                    b.ToTable("TimeTables");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.AdmitCard", b =>
                {
                    b.HasOne("SMS.Infrastructure.Entities.Exam", "Exam")
                        .WithMany("AdmitCards")
                        .HasForeignKey("ExamId")
                        .IsRequired();

                    b.HasOne("SMS.Infrastructure.Entities.Student", "Student")
                        .WithMany("AdmitCards")
                        .HasForeignKey("StudentId")
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.Class", b =>
                {
                    b.HasOne("SMS.Infrastructure.Entities.Teacher", "Teacher")
                        .WithMany("Classes")
                        .HasForeignKey("TeacherId");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.ClassStudent", b =>
                {
                    b.HasOne("SMS.Infrastructure.Entities.Class", "Class")
                        .WithMany("ClassStudents")
                        .HasForeignKey("ClassId")
                        .IsRequired();

                    b.HasOne("SMS.Infrastructure.Entities.Student", "Student")
                        .WithMany("ClassStudents")
                        .HasForeignKey("StudentId")
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.Event", b =>
                {
                    b.HasOne("SMS.Infrastructure.Entities.Teacher", "Teacher")
                        .WithMany("Events")
                        .HasForeignKey("TeacherId")
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.Fee", b =>
                {
                    b.HasOne("SMS.Infrastructure.Entities.Student", "Student")
                        .WithMany("Fees")
                        .HasForeignKey("StudentId")
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.Notice", b =>
                {
                    b.HasOne("SMS.Infrastructure.Entities.Teacher", "Teacher")
                        .WithMany("Notices")
                        .HasForeignKey("TeacherId")
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.Result", b =>
                {
                    b.HasOne("SMS.Infrastructure.Entities.Exam", "Exam")
                        .WithMany("Results")
                        .HasForeignKey("ExamId")
                        .IsRequired();

                    b.HasOne("SMS.Infrastructure.Entities.Student", "Student")
                        .WithMany("Results")
                        .HasForeignKey("StudentId")
                        .IsRequired();

                    b.HasOne("SMS.Infrastructure.Entities.Subject", "Subject")
                        .WithMany("Results")
                        .HasForeignKey("SubjectId")
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.Student", b =>
                {
                    b.HasOne("SMS.Infrastructure.Entities.Address", "Address")
                        .WithMany("Students")
                        .HasForeignKey("AddressId")
                        .IsRequired();

                    b.HasOne("SMS.Infrastructure.Entities.Parent", "Parents")
                        .WithMany("Students")
                        .HasForeignKey("ParentId")
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Parents");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.Teacher", b =>
                {
                    b.HasOne("SMS.Infrastructure.Entities.Address", "Address")
                        .WithMany("Teachers")
                        .HasForeignKey("AddressId")
                        .IsRequired();

                    b.HasOne("SMS.Infrastructure.Entities.Subject", "Subject")
                        .WithMany("Teachers")
                        .HasForeignKey("SubjectId")
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.TimeTable", b =>
                {
                    b.HasOne("SMS.Infrastructure.Entities.Class", "Class")
                        .WithMany("TimeTables")
                        .HasForeignKey("ClassId")
                        .IsRequired();

                    b.HasOne("SMS.Infrastructure.Entities.Subject", "Subject")
                        .WithMany("TimeTables")
                        .HasForeignKey("SubjectId")
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.Address", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.Class", b =>
                {
                    b.Navigation("ClassStudents");

                    b.Navigation("TimeTables");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.Exam", b =>
                {
                    b.Navigation("AdmitCards");

                    b.Navigation("Results");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.Parent", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.Student", b =>
                {
                    b.Navigation("AdmitCards");

                    b.Navigation("ClassStudents");

                    b.Navigation("Fees");

                    b.Navigation("Results");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.Subject", b =>
                {
                    b.Navigation("Results");

                    b.Navigation("Teachers");

                    b.Navigation("TimeTables");
                });

            modelBuilder.Entity("SMS.Infrastructure.Entities.Teacher", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("Events");

                    b.Navigation("Notices");
                });
#pragma warning restore 612, 618
        }
    }
}
