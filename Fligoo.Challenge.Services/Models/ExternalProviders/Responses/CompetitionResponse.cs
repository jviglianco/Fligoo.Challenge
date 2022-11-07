using System;
using System.Collections.Generic;

namespace Fligoo.Challenge.Services.Models.ExternalProviders
{
    public class CompetitionResponse
    {
        public AreaResponse Area { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public string Emblem { get; set; }
        public string Plan { get; set; }
        public SeasonResponse CurrentSeason { get; set; }
        public IEnumerable<SeasonResponse> Seasons { get; set; }
        public int NumberOfAvailableSeasons { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}