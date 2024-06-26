using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SMS.Infrastructure.Entities
{
    [Index("Id", Name = "UQ__Fees__3214EC06FB5FEE88", IsUnique = true)]
    public partial class Fee
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal FeeAmount { get; set; }
        [Column(TypeName = "date")]
        public DateTime DueDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PaidDate { get; set; }
        public int StudentId { get; set; }

        [ForeignKey("StudentId")]
        [InverseProperty("Fees")]
        public virtual Student Student { get; set; } = null!;
    }
}
