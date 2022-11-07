using Fligoo.Challenge.Services;
using System.Threading.Tasks;
using System.Web.Http;

namespace Fligoo.Challenge.Controllers
{
    public class ImportsController : ApiController
    {
        private readonly ICompetitionService _competitionService;

        public ImportsController(ICompetitionService competitionService)
        {
            _competitionService = competitionService;
        }

        [HttpPost]
        public async Task<IHttpActionResult> ImportDataFromFD()
        {
            await _competitionService.ImportDataFromFD();

            return Ok();
        }
    }
}