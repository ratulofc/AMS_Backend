using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SMS.Infrastructure.Entities
{
    public partial class Student
    {
        public Student()
        {
            AdmitCards = new HashSet<AdmitCard>();
            ClassStudents = new HashSet<ClassStudent>();
            Fees = new HashSet<Fee>();
            Results = new HashSet<Result>();
        }

        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public DateTime Dob { get; set; }
        public string PhoneNo { get; set; } = null!;
        public bool IsEmailVerified { get; set; }
        public DateTime DateOfJoin { get; set; }
        public bool Status { get; set; }
        public DateTime LastLoginDate { get; set; }
        public string Avatar { get; set; } = null!;
        public int AddressId { get; set; }
        public int ParentId { get; set; }

        public virtual Address Address { get; set; } = null!;
        public virtual Parent Parents { get; set; } = null!;
        public virtual ICollection<AdmitCard> AdmitCards { get; set; }
        public virtual ICollection<ClassStudent> ClassStudents { get; set; }
        public virtual ICollection<Fee> Fees { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}
