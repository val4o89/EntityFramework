using System.Collections.Generic;

namespace FootballBettingDatabase.Models
{
    public class Competition
    {
        public Competition()
        {
            this.Games = new HashSet<Game>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public CompetitionType CompetitionType { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}