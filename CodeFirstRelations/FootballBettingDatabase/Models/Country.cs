using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FootballBettingDatabase.Models
{
    public class Country
    {
        public Country()
        {
            this.Towns = new HashSet<Town>();
            this.Continents = new HashSet<Continent>();
        }
        [MaxLength(3)]
        [MinLength(3)]
        public string Id { get; set; }

        public string Name { get; set; }

        public ICollection<Town> Towns { get; set; }

        public virtual ICollection<Continent> Continents { get; set; }
    }
}