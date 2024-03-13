namespace TestTaskWebApp.Models
{
    public class ResponseDataNormal<T>
	{
		public bool IsSuccess { get; set; }
		public T Data { get; set; }
		public string Message { get; set; }
		public int Status { get; set; }
	}
}
