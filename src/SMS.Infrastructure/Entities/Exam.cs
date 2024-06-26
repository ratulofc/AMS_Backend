using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SMS.Infrastructure.Entities
{
    public partial class Exam
    {
        public Exam()
        {
            AdmitCards = new HashSet<AdmitCard>();
            Results = new HashSet<Result>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; } = null!;
        public string Type { get; set; } = null!;
        public virtual ICollection<AdmitCard> AdmitCards { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}
