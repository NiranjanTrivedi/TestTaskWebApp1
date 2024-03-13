namespace TestTaskWebApp.Models
{
    public class LoginResponse
    {
        public bool IsSuccess { get; set; }
        public string Data { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
    }
}
