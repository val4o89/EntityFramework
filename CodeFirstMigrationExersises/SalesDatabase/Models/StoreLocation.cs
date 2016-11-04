using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Models
{
    public class StoreLocation
    {
        public int Id { get; set; }

        public string LocationName { get; set; }

        public ICollection<Sale> Sales { get; set; }
    }
}
