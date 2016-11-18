using System.Collections.Generic;

namespace FootballBettingDatabase.Models
{
    public class Round
    {
        public Round()
        {
            this.Games = new HashSet<Game>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}