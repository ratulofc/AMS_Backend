using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SMS.Infrastructure.Entities
{
    [Index("Id", Name = "UQ__Exams__3214EC06CFADBB48", IsUnique = true)]
    public partial class Exam
    {
        public Exam()
        {
            AdmitCards = new HashSet<AdmitCard>();
            Results = new HashSet<Result>();
        }

        [Key]
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [StringLength(20)]
        public string Type { get; set; } = null!;

        [InverseProperty("Exam")]
        public virtual ICollection<AdmitCard> AdmitCards { get; set; }
        [InverseProperty("Exam")]
        public virtual ICollection<Result> Results { get; set; }
    }
}
