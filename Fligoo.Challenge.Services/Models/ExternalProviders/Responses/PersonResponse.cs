using System;

namespace Fligoo.Challenge.Services.Models.ExternalProviders
{
    public class PersonResponse
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Nationality { get; set; }
    }
}
