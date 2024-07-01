using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMS.Core.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Results = new HashSet<Result>();
            Teachers = new HashSet<Teacher>();
            TimeTables = new HashSet<TimeTable>();
        }

        public int Id { get; set; }
        public string SubjectName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Grade { get; set; }

        public virtual ICollection<Result> Results { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<TimeTable> TimeTables { get; set; }
    }
}
