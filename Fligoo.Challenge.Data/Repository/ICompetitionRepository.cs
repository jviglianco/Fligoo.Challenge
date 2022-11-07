using Fligoo.Challenge.Data.Entities;
using System.Collections.Generic;

namespace Fligoo.Challenge.Data.Repository
{
    public interface ICompetitionRepository
    {
        List<Competition> GetCompetitions();
        void InsertCompetitions(IEnumerable<Competition> competitions);
        void InsertCompetition(Competition competition);
        void Save();
    }
}