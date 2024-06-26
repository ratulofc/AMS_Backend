using Microsoft.EntityFrameworkCore;
using SMS.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Infrastructure.Context
{
    public partial class SMSDBContext : DbContext
    {
        public SMSDBContext() { }
        public SMSDBContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Address> Addresses { get; set; } = null!;
        public virtual DbSet<AdmitCard> AdmitCards { get; set; } = null!;
        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<ClassStudent> ClassStudents { get; set; } = null!;
        public virtual DbSet<Event> Events { get; set; } = null!;
        public virtual DbSet<Exam> Exams { get; set; } = null!;
        public virtual DbSet<Fee> Fees { get; set; } = null!;
        public virtual DbSet<Notice> Notices { get; set; } = null!;
        public virtual DbSet<Parent> Parents { get; set; } = null!;
        public virtual DbSet<Result> Results { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Subject> Subjects { get; set; } = null!;
        public virtual DbSet<Teacher> Teachers { get; set; } = null!;
        public virtual DbSet<TimeTable> TimeTables { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(e => e.Id);       // To set Id as a primary key
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();     // To set Id auto increment

                entity.Property(e => e.Name)
                    .HasColumnType("nvarchar")  // To set column data type
                    .HasMaxLength(50)           // To set column length
                    .IsRequired(true);          // To set column NOT NULL

                entity.Property(e => e.MobileNo)
                    .HasColumnType("nvarchar")  // To set column data type
                    .HasMaxLength(10)           // To set column length
                    .IsFixedLength();           // To ensure that the length of property is fixed

                entity.Property(e => e.City)
                    .HasColumnType("nvarchar")
                    .HasMaxLength(50)
                    .IsRequired(true);

                entity.Property(e => e.State)
                    .HasColumnType("nvarchar")
                    .HasMaxLength(50)
                    .IsRequired(true);

                entity.Property(e => e.Pincode)
                    .HasColumnType("nvarchar")
                    .HasMaxLength(6)
                    .IsRequired(true);

                entity.Property(e => e.StreetAddress)
                    .HasColumnType("nvarchar")
                    .HasMaxLength(100)
                    .IsRequired(true);

                entity.Property(e => e.LandMark)
                    .HasColumnType("nvarchar")
                    .HasMaxLength(50)
                    .IsRequired(true);
            });

            modelBuilder.Entity<AdmitCard>(entity =>
            {
                entity.HasKey(e => e.Id);       // To set Id as a primary key
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();     // To set Id auto increment

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.AdmitCards)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.AdmitCards)
                    .HasForeignKey(d => d.ExamId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.HasKey(e => e.Id);       // To set Id as a primary key
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();     // To set Id auto increment

                entity.Property(e => e.Section)
                    .HasColumnType("nvarchar")
                    .HasMaxLength(50)
                    .IsRequired(true);



                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ClassStudent>(entity =>
            {
                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ClassStudents)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ClassStudents_fk1");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.ClassStudents)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ClassStudents_fk0");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Event_fk6");
            });

            modelBuilder.Entity<Fee>(entity =>
            {
                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Fees)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fees_fk4");
            });

            modelBuilder.Entity<Notice>(entity =>
            {
                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Notices)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Notices_fk5");
            });

            modelBuilder.Entity<Parent>(entity =>
            {
                entity.HasKey(e => e.Id);       // To set Id as a primary key
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();     // To set Id auto increment

                entity.Property(e => e.FirstName)
                    .HasColumnType("nvarchar")  // To set column data type
                    .HasMaxLength(50)           // To set column length
                    .IsRequired(true);          // To set column NOT NULL

                entity.Property(e => e.LastName)
                    .HasColumnType("nvarchar")
                    .HasMaxLength(50)
                    .IsRequired(true);

                entity.Property(e => e.Email)
                    .IsUnicode(true)            // Mapped to nvarchar (It can store nvarchar data)
                    .IsRequired(true)
                    .HasMaxLength(255);
                entity.HasIndex(e => e.Email)   // To ensure that email property will accept
                    .IsUnique(true);            // To ensure all email property will unique

                entity.Property(e => e.PasswordHash)
                    .HasColumnType("nvarchar")  // To set column data type
                    .HasMaxLength(255)          // To set column length
                    .IsRequired(true);          // To set column NOT NULL

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB")       // To set column name as DOB
                    .IsRequired(true);          // To set column NOT NULL

                entity.Property(e => e.PhoneNo)
                    .HasColumnType("nvarchar")  // To set column data type
                    .HasMaxLength(10)           // To set column length
                    .IsFixedLength();           // To ensure that the length of property is fixed

                entity.Property(e => e.LastLoginDate)
                    .HasColumnType("datetime")
                    .IsRequired(true);          // To set column NOT NULL

            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.ExamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Results_fk1");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Results_fk2");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Results_fk3");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Id);       // To set Id as a primary key
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();     // To set Id auto increment

                entity.Property(e => e.FirstName)
                    .HasColumnType("nvarchar")  // To set column data type
                    .HasMaxLength(50)           // To set column length
                    .IsRequired(true);          // To set column NOT NULL

                entity.Property(e => e.LastName)
                    .HasColumnType("nvarchar")  // To set column data type
                    .HasMaxLength(50)           // To set column length
                    .IsRequired(true);          // To set column NOT NULL

                entity.Property(e => e.Email)
                    .IsUnicode(true)            // Mapped to nvarchar (It can store nvarchar data)
                    .IsRequired(true)
                    .HasMaxLength(255);
                entity.HasIndex(e => e.Email)   // To ensure that email property will accept
                    .IsUnique(true);            // To ensure all email property will unique

                entity.Property(e => e.PasswordHash)
                    .HasColumnType("nvarchar")  // To set column data type
                    .HasMaxLength(255)          // To set column length
                    .IsRequired(true);          // To set column NOT NULL

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB")       // To set column name as DOB
                    .IsRequired(true);          // To set column NOT NULL

                entity.Property(e => e.PhoneNo)
                    .HasColumnType("nvarchar")  // To set column data type
                    .HasMaxLength(10)           // To set column length
                    .IsFixedLength();           // To ensure that the length of property is fixed

                entity.Property(e => e.Status)
                    .IsRequired(true);          // To set column NOT NULL

                entity.Property(e => e.LastLoginDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB")       // To set column name as DOB
                    .IsRequired(true);          // To set column NOT NULL

                entity.Property(e => e.Avatar)
                    .HasColumnType("nvarchar")  // To set column data type
                    .HasMaxLength(512)          // To set column length
                    .IsRequired(true);          // To set column NOT NULL

                entity.HasOne(d => d.Address)   // To set one to many relationship and set foregin key, We need to white where we define forrgin key
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.AddressId)  // This way we can set Foregin key
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Parents)   // To set one to many relationship and set foregin key, We need to white where we define forrgin key
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.ParentId)   // This way we can set Foregin key
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Teachers_fk11");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Teachers_fk12");
            });

            modelBuilder.Entity<TimeTable>(entity =>
            {
                entity.HasOne(d => d.Class)
                    .WithMany(p => p.TimeTables)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TimeTables_fk5");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.TimeTables)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TimeTables_fk4");
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
