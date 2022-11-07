namespace Fligoo.Challenge.Services.Models.ExternalProviders
{
    public class AreaResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Flag { get; set; }
        public int? ParentAreaId { get; set; }
        public string ParentArea { get; set; }
    }
}