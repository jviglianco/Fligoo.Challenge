using Fligoo.Challenge.Data.Entities;
using System.Data.Entity;

namespace Fligoo.Challenge.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() :
          base("name=FDDB")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Competition>()
                .HasKey(s => s.Id);

            modelBuilder.Entity<Team>()
                .HasKey(s => s.Id)
                .HasRequired(s => s.Competition)
                .WithMany(g => g.Teams)
                .HasForeignKey(s => s.CompetitionId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Player>()
                .HasKey(s => s.Id)
                .HasRequired(s => s.Team)
                .WithMany(g => g.Players)
                .HasForeignKey(s => s.TeamId)
                .WillCascadeOnDelete();
        }
    }
}
