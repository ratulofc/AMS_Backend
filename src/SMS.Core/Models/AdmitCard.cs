using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMS.Core.Models
{
    public partial class AdmitCard
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public virtual Exam Exam { get; set; } = null!;
        public virtual Student Student { get; set; } = null!;
    }
}
