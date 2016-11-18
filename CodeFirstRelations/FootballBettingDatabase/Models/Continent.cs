using System.Collections;
using System.Collections.Generic;

namespace FootballBettingDatabase.Models
{
    public class Continent
    {
        public Continent()
        {
            this.Countries = new HashSet<Country>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Country> Countries { get; set; }
    }
}