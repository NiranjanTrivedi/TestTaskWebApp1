using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TestTaskWebApp.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string ProfilePicture { get; set; }
        public string EmailId { get; set; }
    }
}
