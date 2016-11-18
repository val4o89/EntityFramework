namespace FootballBettingDatabase.Context
{
    using Migrations;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class FootbalContext : DbContext
    {
        public FootbalContext()
            : base("FootbalContext")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<FootbalContext>());
        }

        public IDbSet<Bet> Bets { get; set; }
        public IDbSet<BetGame> BetGames { get; set; }
        public IDbSet<Color> Colors { get; set; }
        public IDbSet<Competition> Competitions { get; set; }
        public IDbSet<CompetitionType> CompetitionTypes { get; set; }
        public IDbSet<Continent> Continents { get; set; }
        public IDbSet<Country> Countries { get; set; }
        public IDbSet<Town> Towns { get; set; }
        public IDbSet<Game> Games { get; set; }
        public IDbSet<Player> Players { get; set; }
        public IDbSet<PlayerStatistic> PlayerStatistics { get; set; }
        public IDbSet<Position> Positions { get; set; }
        public IDbSet<ResultPrediction> ResultPredictions { get; set; }
        public IDbSet<Round> Rounds { get; set; }
        public IDbSet<Team> Teams { get; set; }
        public IDbSet<User> Users { get; set; }
    }
}