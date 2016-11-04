using System.Collections;
using System.Collections.Generic;

namespace UsersDb.Models
{
    public class Country
    {
        public Country()
        {
            this.Towns = new HashSet<Town>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Town> Towns { get; set; }
    }
}