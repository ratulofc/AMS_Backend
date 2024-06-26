using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SMS.Infrastructure.Entities
{
    public partial class Notice
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Title { get; set; } = null!;
        [StringLength(100)]
        public string Description { get; set; } = null!;
        public DateTime PostedOn { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; } = null!;
    }
}
