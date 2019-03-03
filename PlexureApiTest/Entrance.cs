using System;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Json;

namespace PlexureApiTest.Model
{
    public class Entrance
    {
        private static readonly HttpClient httpClient;

        static Entrance()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://qatestapi.azurewebsites.net");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }

        public async Task<IResponse> Login(string UserName, string Passwrod)
        {

            var request = new HttpRequestMessage(HttpMethod.Post, httpClient.BaseAddress);
            string requestBody = "body: { username:" + UserName + ", password:" + Passwrod + "}";


            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("https://qatestapi.azurewebsites.net");

            } 
            catch(HttpRequestException e)
            {

            }
        }

    }
}
