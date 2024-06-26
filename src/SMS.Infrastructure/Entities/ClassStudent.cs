using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SMS.Infrastructure.Entities
{
    public partial class ClassStudent
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }

        public virtual Class Class { get; set; } = null!;
        public virtual Student Student { get; set; } = null!;
    }
}
