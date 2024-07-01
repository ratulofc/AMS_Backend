using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMS.Core.Models
{
    public partial class Address
    {
        public Address()
        {
            Students = new HashSet<Student>();
            Teachers = new HashSet<Teacher>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string MobileNo { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Pincode { get; set; } = null!;
        public string StreetAddress { get; set; } = null!;
        public string LandMark { get; set; } = null!;
        public virtual ICollection<Student> Students { get; set; } = null!;
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
