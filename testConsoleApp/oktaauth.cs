﻿//using System;
//using System.Collections.Generic;
//using System.Net.Http;
//using System.Net.Http.Headers;
//using System.Text;
//using System.Threading.Tasks;

//namespace testConsoleApp
//{
//	internal class OktaToken
//	{
//		public string access_token { get; set; }
//		public int expires_in { get; set; }
//		public DateTime ExpiresAt { get; set; }
//		public string Scope { get; set; }
//		public string token_type { get; set; }

//	}
//	public class oktaauth
//    {
//		private async Task<OktaToken> GetNewAccessToken()
//		{
//			string clientId = "", clientSecret = "";
//			var client = new HttpClient();
//			var clientCreds = System.Text.Encoding.UTF8.GetBytes($"{clientId}:{clientSecret}");

//			client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(clientCreds));

//			var postMessage = new Dictionary<string, string>
//			{
//				{"grant_type", "client_credentials"},
//				{"scope", "access_token"}
//			};

//			var request = new HttpRequestMessage(HttpMethod.Post, _oktaSettings.Value.TokenUrl)
//			{
//				Content = new FormUrlEncodedContent(postMessage)
//			};

//			var response = await client.SendAsync(request);
//			if (response.IsSuccessStatusCode)
//			{
//				var json = await response.Content.ReadAsStringAsync();
//				var newToken = JsonConvert.DeserializeObject<OktaToken>(json);
//				newToken.ExpiresAt = DateTime.UtcNow.AddSeconds(_token.ExpiresIn);

//				return newToken;
//			}

//			throw new ApplicationException("Unable to retrieve access token from Okta");
//		}
//	}
//}
