using System.Data.Entity.Migrations;

namespace Fligoo.Challenge.Data.Migrations
{
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Competitions",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                    Code = c.String(nullable: false),
                    Type = c.String(nullable: false),
                    Emblem = c.String(nullable: false),
                    Plan = c.String(nullable: false),
                    NumberOfAvailableSeasons = c.Int(nullable: false),
                    LastUpdated = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Teams",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                    ShortName = c.String(nullable: false),
                    Tla = c.String(nullable: false),
                    Crest = c.String(nullable: false),
                    Address = c.String(nullable: false),
                    Website = c.String(nullable: false),
                    Founded = c.Int(nullable: false),
                    ClubColors = c.String(nullable: false),
                    Venue = c.String(nullable: false),
                    LastUpdated = c.DateTime(nullable: false),
                    CompetitionId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Competitions", t => t.CompetitionId, cascadeDelete: true)
                .Index(t => t.CompetitionId);

            CreateTable(
                "dbo.Players",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                    Position = c.String(nullable: false),
                    DateOfBirth = c.DateTime(nullable: false),
                    Nationality = c.String(nullable: false),
                    TeamId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Players", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.Teams", "CompetitionId", "dbo.Competitions");
            DropIndex("dbo.Players", new[] { "TeamId" });
            DropIndex("dbo.Teams", new[] { "CompetitionId" });
            DropTable("dbo.Players");
            DropTable("dbo.Teams");
            DropTable("dbo.Competitions");
        }
    }
}
