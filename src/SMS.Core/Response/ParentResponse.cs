using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Response
{
    public class ParentResponse
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public DateTime Dob { get; set; }
        public string PhoneNo { get; set; } = null!;
        public DateTime LastLoginDate { get; set; }
    }
}
