using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SMS.Infrastructure.Entities
{
    [Index("Id", Name = "UQ__TimeTabl__3214EC063493981E", IsUnique = true)]
    public partial class TimeTable
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int SubjectId { get; set; }
        public int ClassId { get; set; }

        [ForeignKey("ClassId")]
        [InverseProperty("TimeTables")]
        public virtual Class Class { get; set; } = null!;
        [ForeignKey("SubjectId")]
        [InverseProperty("TimeTables")]
        public virtual Subject Subject { get; set; } = null!;
    }
}
