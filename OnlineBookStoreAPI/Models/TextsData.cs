namespace OnlineBookStoreAPI.Models
{
	using Newtonsoft.Json;
	public class TextsData
	{
		[JsonProperty("textsData")]
        public List<LatinText> TextData { get; set; }
    }
}
