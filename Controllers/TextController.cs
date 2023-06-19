using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnlineBookStoreAPI.Models;

namespace OnlineBookStoreAPI.Controllers
{
	public class TextController : BaseApiController
	{
		[HttpGet("LatinText")]
		public async Task<ActionResult<IEnumerable<TextsData>>> GetText() 
		{
			try
			{
				var textResult = await CallExternalApiText();	
				
				return Ok(textResult);
			}
			catch (Exception e) 
			{
				throw;
			}
		}

		#region Helper Methods
		public async Task<List<LatinText>> CallExternalApiText()
		{
			List<LatinText> textsData = new List<LatinText>();

			using (var httpClient = new HttpClient())
			{
				using (var response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts")) 
				{
					string apiResponse = await response.Content.ReadAsStringAsync();
					if (!string.IsNullOrEmpty(apiResponse))
					{
						textsData = JsonConvert.DeserializeObject<List<LatinText>>(apiResponse);
					}
					
				}
			}

			return textsData;
		}

		#endregion
	}
}
