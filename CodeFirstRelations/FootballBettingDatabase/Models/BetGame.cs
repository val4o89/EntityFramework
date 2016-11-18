using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballBettingDatabase.Models
{
    public class BetGame
    {
        public BetGame()
        {

        }

        public Game Games { get; set; }

        [Key]
        [Column(Order = 0)]
        public int GameId { get; set; }

        public Bet Bet { get; set; }

        [Key]
        [Column(Order = 1)]
        public int BetId { get; set; }

        public ResultPrediction ResultPrediction { get; set; }
    }
}