using System.ComponentModel.DataAnnotations;

namespace TestTaskWebApp.Models
{
    public class LoginModel
    {
        
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter the Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
       
    }
}
