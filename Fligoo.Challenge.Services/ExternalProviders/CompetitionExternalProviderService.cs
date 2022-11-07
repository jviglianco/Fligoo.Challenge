using Fligoo.Challenge.Services.Models.ExternalProviders;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Fligoo.Challenge.Services.ExternalProviders
{
    public class CompetitionExternalProviderService : ICompetitionExternalProviderService
    {
        private readonly HttpClient _httpClient;
        public CompetitionExternalProviderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<CompetitionsResponse> GetCompetitionsImportAsync()
        {
            CompetitionsResponse competitions = null;
            HttpResponseMessage response = await _httpClient.GetAsync($"competitions/BSA/teams");

            if (response.IsSuccessStatusCode)
            {
                competitions = JsonConvert.DeserializeObject<CompetitionsResponse>(await response.Content.ReadAsStringAsync());
            }

            return competitions;
        }
    }
}
