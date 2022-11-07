using Fligoo.Challenge.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fligoo.Challenge.Services
{
    public interface ICompetitionService
    {
        IEnumerable<CompetitionResponse> GetAllCompetitions();
        Task ImportDataFromFD();
    }
}