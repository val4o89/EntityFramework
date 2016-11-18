using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBettingDatabase.Models
{
    public class Player
    {
        public Player()
        {
            this.PlayerStatistic = new HashSet<PlayerStatistic>();
        }

        public int Id { get; set; }

        public string name { get; set; }

        public int SquadNumber { get; set; }

        public Team Team { get; set; }

        public Position Position { get; set; }

        public ICollection<PlayerStatistic> PlayerStatistic { get; set; }

        public bool IsCurrentlyInjured { get; set; }
    }
}
