using Fligoo.Challenge.Services.Models.ExternalProviders;
using System.Threading.Tasks;

namespace Fligoo.Challenge.Services.ExternalProviders
{
    public interface ICompetitionExternalProviderService
    {
        Task<CompetitionsResponse> GetCompetitionsImportAsync();
    }
}
