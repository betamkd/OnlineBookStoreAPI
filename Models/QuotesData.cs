namespace OnlineBookStoreAPI.Models
{
	using Newtonsoft.Json;
	public class QuotesData
	{
		[JsonProperty("quoteData")]
		public List<Quote> QuoteData { get; set; }
	}
}
