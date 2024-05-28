// TPVVentaExpress.Domain/Entities/User.cs
using System.ComponentModel.DataAnnotations;

namespace TPVVentaExpress.Domain.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
