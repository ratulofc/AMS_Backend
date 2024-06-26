using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SMS.Infrastructure.Entities
{
    [Index("Id", Name = "UQ__ClassStu__3214EC06925FBE88", IsUnique = true)]
    public partial class ClassStudent
    {
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        [Key]
        public int Id { get; set; }

        [ForeignKey("ClassId")]
        [InverseProperty("ClassStudents")]
        public virtual Class Class { get; set; } = null!;
        [ForeignKey("StudentId")]
        [InverseProperty("ClassStudents")]
        public virtual Student Student { get; set; } = null!;
    }
}
