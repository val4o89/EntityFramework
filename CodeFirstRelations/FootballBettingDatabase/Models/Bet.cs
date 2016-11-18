using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBettingDatabase.Models
{
    public class Bet
    {
        public Bet()
        {
            this.BetGames = new HashSet<BetGame>();
        }
        public int Id { get; set; }

        public decimal BetMoney { get; set; }

        public DateTime DateOfBet { get; set; }

        public User User { get; set; }

        public ICollection<BetGame> BetGames { get; set;}
    }
}
