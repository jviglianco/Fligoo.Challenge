using Fligoo.Challenge.Services;
using Fligoo.Challenge.Services.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace Fligoo.Challenge.Controllers
{
    public class CompetitionsController : ApiController
    {
        private readonly ICompetitionService _competitionService;
        public CompetitionsController(ICompetitionService competitionService)
        {
            _competitionService = competitionService;
        }

        public IHttpActionResult GetAllCompetitions()
        {
            IEnumerable<CompetitionResponse> competitions = _competitionService.GetAllCompetitions();

            return Ok(competitions);
        }
    }
}