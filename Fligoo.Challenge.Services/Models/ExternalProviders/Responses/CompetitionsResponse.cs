using System.Collections.Generic;

namespace Fligoo.Challenge.Services.Models.ExternalProviders
{
    public class CompetitionsResponse
    {
        public int Count { get; set; }
        public dynamic Filters { get; set; }
        public CompetitionResponse Competition { get; set; }
        public SeasonResponse Season { get; set; }
        public IEnumerable<TeamResponse> Teams { get; set; }
    }
}