using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SMS.Infrastructure.Entities
{
    [Index("Id", Name = "UQ__Subjects__3214EC062E9D17EA", IsUnique = true)]
    public partial class Subject
    {
        public Subject()
        {
            Results = new HashSet<Result>();
            Teachers = new HashSet<Teacher>();
            TimeTables = new HashSet<TimeTable>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string SubjectName { get; set; } = null!;
        [StringLength(255)]
        public string Description { get; set; } = null!;
        public int Grade { get; set; }

        [InverseProperty("Subject")]
        public virtual ICollection<Result> Results { get; set; }
        [InverseProperty("Subject")]
        public virtual ICollection<Teacher> Teachers { get; set; }
        [InverseProperty("Subject")]
        public virtual ICollection<TimeTable> TimeTables { get; set; }
    }
}
