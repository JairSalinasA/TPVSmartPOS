using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPost.DataAccess.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastAccess { get; set; }
        public bool IsActive { get; set; }
    }
}
