namespace OnlineBookStoreAPI.Models
{
	public class LatinText
	{
		public int UserId { get; set; }
		public int Id { get; set; }
		public string Title { get; set; } = null!;
		public string Body { get; set; } = null!;
    }
}
