using System;
using System.ComponentModel.DataAnnotations;

namespace Fligoo.Challenge.Data.Entities
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Nationality { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
