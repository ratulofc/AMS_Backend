using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SMS.Infrastructure.Entities
{
    [Index("Id", Name = "UQ__Teachers__3214EC06641E1C57", IsUnique = true)]
    [Index("Email", Name = "UQ__Teachers__A9D10534869DDFFA", IsUnique = true)]
    public partial class Teacher
    {
        public Teacher()
        {
            Classes = new HashSet<Class>();
            Events = new HashSet<Event>();
            Notices = new HashSet<Notice>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; } = null!;
        [StringLength(50)]
        public string LastName { get; set; } = null!;
        [StringLength(255)]
        public string Email { get; set; } = null!;
        [StringLength(255)]
        public string PasswordHash { get; set; } = null!;
        [Column("DOB", TypeName = "datetime")]
        public DateTime Dob { get; set; }
        [StringLength(15)]
        public string PhoneNo { get; set; } = null!;
        public bool Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateOfJoin { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastLoginDate { get; set; }
        [StringLength(512)]
        public string Avatar { get; set; } = null!;
        public int AddressId { get; set; }
        public int SubjectId { get; set; }

        [ForeignKey("AddressId")]
        [InverseProperty("Teachers")]
        public virtual Address Address { get; set; } = null!;
        [ForeignKey("SubjectId")]
        [InverseProperty("Teachers")]
        public virtual Subject Subject { get; set; } = null!;
        [InverseProperty("Teacher")]
        public virtual ICollection<Class> Classes { get; set; }
        [InverseProperty("Teacher")]
        public virtual ICollection<Event> Events { get; set; }
        [InverseProperty("Teacher")]
        public virtual ICollection<Notice> Notices { get; set; }
    }
}
