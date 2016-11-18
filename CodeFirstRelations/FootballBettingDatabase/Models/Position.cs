using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FootballBettingDatabase.Models
{
    public class Position
    {
        [MinLength(2)]
        [MaxLength(2)]
        public string Id { get; set; }

        public string PositionDescription { get; set; }

        public ICollection<Player> Players { get; set; }


    }
}