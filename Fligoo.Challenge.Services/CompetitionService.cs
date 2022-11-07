using AutoMapper;
using Fligoo.Challenge.Data.Entities;
using Fligoo.Challenge.Data.Repository;
using Fligoo.Challenge.Services.ExternalProviders;
using Fligoo.Challenge.Services.Models.ExternalProviders;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fligoo.Challenge.Services
{
    public class CompetitionService : ICompetitionService
    {
        private readonly ICompetitionRepository _competitionRepository;
        private readonly ICompetitionExternalProviderService _competitionExternalProviderService;
        private readonly IMapper _mapper;
        public CompetitionService(ICompetitionRepository competitionRepository,
                                  ICompetitionExternalProviderService competitionExternalProviderService,
                                  IMapper mapper)
        {
            _competitionExternalProviderService = competitionExternalProviderService;
            _competitionRepository = competitionRepository;
            _mapper = mapper;
        }

        public IEnumerable<Models.CompetitionResponse> GetAllCompetitions()
        {
            List<Competition> competitions = _competitionRepository.GetCompetitions();

            return competitions.Select(x => _mapper.Map<Models.CompetitionResponse>(x));
        }

        public async Task ImportDataFromFD()
        {
            CompetitionsResponse competitionsResponse = await _competitionExternalProviderService.GetCompetitionsImportAsync();

            Competition competition = _mapper.Map<Competition>(competitionsResponse.Competition);

            _competitionRepository.InsertCompetition(competition);

            _competitionRepository.Save();
        }
    }
}