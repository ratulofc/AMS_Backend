using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SMS.Infrastructure.Entities
{
    public partial class Parent
    {
        public Parent()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public DateTime Dob { get; set; }
        public string PhoneNo { get; set; } = null!;
        public DateTime LastLoginDate { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
