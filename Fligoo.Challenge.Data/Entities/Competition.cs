using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fligoo.Challenge.Data.Entities
{
    public class Competition
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Emblem { get; set; }
        [Required(AllowEmptyStrings = true)]
        public string Plan { get; set; }
        [Required]
        public int NumberOfAvailableSeasons { get; set; }
        [Required]
        public DateTime LastUpdated { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}
