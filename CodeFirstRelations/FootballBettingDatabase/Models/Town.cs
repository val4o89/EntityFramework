using System.Collections.Generic;

namespace FootballBettingDatabase.Models
{
    public class Town
    {
        public Town()
        {
            this.HostedTeams = new HashSet<Team>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public Country Country { get; set; }

        public virtual ICollection<Team> HostedTeams { get; set; }
    }
}