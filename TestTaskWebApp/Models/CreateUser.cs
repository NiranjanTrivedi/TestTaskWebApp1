using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TestTaskWebApp.Models
{
    public class CreateUser
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "User name is required.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Dob  is required.")]
        public DateTime Dob { get; set; }

        [Required(ErrorMessage = "Address  is required.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter valid image")]
        public string ProfilePicture { get; set; } // Change to string type

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string EmailId { get; set; }
      
    }
}
