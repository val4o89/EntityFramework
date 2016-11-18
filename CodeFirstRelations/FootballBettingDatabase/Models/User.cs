﻿using System.Collections.Generic;

namespace FootballBettingDatabase.Models
{
    public class User
    {
        public User()
        {
            this.Bets = new HashSet<Bet>();
        }

        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string FullName { get; set; }

        public decimal Ballance { get; set; }

        public ICollection<Bet> Bets { get; set; }
    }
}