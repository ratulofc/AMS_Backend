using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SMS.Infrastructure.Entities
{
    public partial class Fee
    {
        public int Id { get; set; }
        public decimal FeeAmount { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? PaidDate { get; set; }
        public int StudentId { get; set; }

        public virtual Student Student { get; set; } = null!;
    }
}
