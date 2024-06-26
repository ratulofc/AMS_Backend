using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SMS.Infrastructure.Entities
{
    [Index("Id", Name = "UQ__Results__3214EC068B71D55B", IsUnique = true)]
    public partial class Result
    {
        [Key]
        public int Id { get; set; }
        public int ExamId { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Marks { get; set; }

        [ForeignKey("ExamId")]
        [InverseProperty("Results")]
        public virtual Exam Exam { get; set; } = null!;
        [ForeignKey("StudentId")]
        [InverseProperty("Results")]
        public virtual Student Student { get; set; } = null!;
        [ForeignKey("SubjectId")]
        [InverseProperty("Results")]
        public virtual Subject Subject { get; set; } = null!;
    }
}
