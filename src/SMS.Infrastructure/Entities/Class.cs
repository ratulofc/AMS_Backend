﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SMS.Infrastructure.Entities
{
    public partial class Class
    {
        public Class()
        {
            ClassStudents = new HashSet<ClassStudent>();
            TimeTables = new HashSet<TimeTable>();
        }

        public int Id { get; set; }
        public string Section { get; set; } = null!;
        public DateTime Year { get; set; }
        public int TeacherId { get; set; }

        [ForeignKey("TeacherId")]
        [InverseProperty("Classes")]
        public virtual Teacher Teacher { get; set; } = null!;
        [InverseProperty("Class")]
        public virtual ICollection<ClassStudent> ClassStudents { get; set; }
        [InverseProperty("Class")]
        public virtual ICollection<TimeTable> TimeTables { get; set; }
    }
}
