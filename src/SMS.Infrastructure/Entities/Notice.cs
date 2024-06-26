using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SMS.Infrastructure.Entities
{
    [Index("Id", Name = "UQ__Notices__3214EC0685C23017", IsUnique = true)]
    public partial class Notice
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Title { get; set; } = null!;
        [StringLength(100)]
        public string Description { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime PostedOn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ExpiryDate { get; set; }
        public int TeacherId { get; set; }

        [ForeignKey("TeacherId")]
        [InverseProperty("Notices")]
        public virtual Teacher Teacher { get; set; } = null!;
    }
}
