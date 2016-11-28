using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.AuthenticationHelpers
{
    public class AuthenticationHelper: IAuthenticationHelper
    {
        public async Task<string> GetAuthorizationToken(string baseUrl, string userName, string password)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));

                var form = new Dictionary<string, string>
                       {
                           {"grant_type", "password"},
                           {"username", userName},
                           {"password", password},
                           {"response_type", "token"},
                       };

                HttpResponseMessage response = await client.PostAsync("token", new FormUrlEncodedContent(form));
                if (response.IsSuccessStatusCode)
                {
                    var token = response.Content.ReadAsAsync<Token>(new[] { new JsonMediaTypeFormatter() }).Result;
                    return token.AccessToken;
                }
                return null;
            }
        }
    }
}
