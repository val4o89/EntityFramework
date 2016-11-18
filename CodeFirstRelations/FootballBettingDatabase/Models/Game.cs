using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBettingDatabase.Models
{
    public class Game
    {
        public Game()
        {

        }

        public int Id { get; set; }

        public Team HomeTeam { get; set; }

        public Team AwayTeam { get; set; }

        public int HomeGoals { get; set; }

        public int AwayGoals { get; set; }

        public DateTime? DateAndTimeOfGame { get; set; }

        public ICollection<BetGame> BetGame { get; set; }

        public Round Round { get; set; }

        public Competition Competition { get; set; }

        public ICollection<PlayerStatistic> PlayerStatistic { get; set; }
    }
}
