using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fligoo.Challenge.Data.Entities
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ShortName { get; set; }
        [Required]
        public string Tla { get; set; }
        [Required]
        public string Crest { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Website { get; set; }
        [Required]
        public int Founded { get; set; }
        [Required]
        public string ClubColors { get; set; }
        [Required]
        public string Venue { get; set; }
        [Required]
        public DateTime LastUpdated { get; set; }
        public int CompetitionId { get; set; }
        public Competition Competition { get; set; }
        public ICollection<Player> Players { get; set; }
    }
}
