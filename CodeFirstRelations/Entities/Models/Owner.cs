using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Owner
    {
        public Owner()
        {
            this.Albums = new HashSet<Album>();
        }

        public int Id { get; set; }

        public ICollection<Album> Albums { get; set; }
    }
}
