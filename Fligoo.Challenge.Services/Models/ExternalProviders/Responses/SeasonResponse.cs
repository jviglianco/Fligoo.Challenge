using System;

namespace Fligoo.Challenge.Services.Models.ExternalProviders
{
    public class SeasonResponse
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? CurrentMatchday { get; set; }
        public TeamResponse Winner { get; set; }
    }
}