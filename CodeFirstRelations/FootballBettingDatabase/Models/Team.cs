using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBettingDatabase.Models
{
    public class Team
    {
        public Team()
        {
            this.Players = new HashSet<Player>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public byte[] Logo { get; set; }

        [MinLength(3)]
        [MaxLength(3)]
        public string Initials { get; set; }

        public Color PrimaryColorKit { get; set; }

        public Color SecondaryColorKit { get; set; }

        public ICollection<Player> Players { get; set; }

        public Town Town { get; set; }
    }
}
