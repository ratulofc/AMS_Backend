using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SMS.Infrastructure.Entities
{
    [Table("Event")]
    [Index("Id", Name = "UQ__Event__3214EC061BA3B7EC", IsUnique = true)]
    public partial class Event
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [StringLength(100)]
        public string Description { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }
        [StringLength(50)]
        public string Location { get; set; } = null!;
        public int TeacherId { get; set; }

        [ForeignKey("TeacherId")]
        [InverseProperty("Events")]
        public virtual Teacher Teacher { get; set; } = null!;
    }
}
