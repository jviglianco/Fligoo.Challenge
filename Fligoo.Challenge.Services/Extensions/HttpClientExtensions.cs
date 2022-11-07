using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Fligoo.Challenge.Services.Extensions
{
    public static class HttpClientExtensions
    {
        public static void ConfigureHttpClient(this HttpClient client, string baseAdress, string TokenHeader, string token)
        {
            client.BaseAddress = new Uri(baseAdress);
            client.DefaultRequestHeaders.Add(TokenHeader, token);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Accept.Clear();
        }
    }
}