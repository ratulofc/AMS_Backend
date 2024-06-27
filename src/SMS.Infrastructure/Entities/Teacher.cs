using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SMS.Infrastructure.Entities
{
    public partial class Teacher
    {
        public Teacher()
        {
            Classes = new HashSet<Class>();
            Events = new HashSet<Event>();
            Notices = new HashSet<Notice>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public DateTime Dob { get; set; }
        public string PhoneNo { get; set; } = null!;
        public bool Status { get; set; }
        public DateTime DateOfJoin { get; set; }
        public DateTime LastLoginDate { get; set; }
        public string Avatar { get; set; } = null!;
        public int AddressId { get; set; }
        public int SubjectId { get; set; }

        public virtual Address Address { get; set; } = null!;
        public virtual Subject Subject { get; set; } = null!;
        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Notice> Notices { get; set; }
    }
}
