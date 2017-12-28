using System;
using COD.Models.IW;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;

namespace COD
{
	public static class IW
	{
		public static Profile.Data GetProfile(Platform platform, string username)
		{
			using (var client = new HttpClient())
			{
				var response = client.GetAsync($"{Utilities.IW_URL}platform/{Utilities.ResolvePlatform(platform)}/gamer/{username}/profile/").Result;

				if (response.StatusCode != HttpStatusCode.OK) throw new Exception($"Bad response {response.StatusCode}"); //TODO: Use proper exception

				var responseData = response.Content.ReadAsStringAsync().Result;

				dynamic data = JsonConvert.DeserializeObject(responseData);
				if (data.status != "success") throw new Exception(data.data.message); //TODO: Use proper exception

				return JsonConvert.DeserializeObject<Profile>(responseData).data; //Bloated. Handle this without deserializing twice.
			}
		}
	}
}
