namespace TestTaskWebApp.Models
{
    public class ResponseData
    {
        public bool IsSuccess { get; set; }
        public User[] Data { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
    }
}
