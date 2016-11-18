using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Picture
    {
        public Picture()
        {
            this.Albums = new HashSet<Album>();
        }
        public int Id { get; set; }

        public string Title { get; set; }

        public string Caption { get; set; }

        public string Path { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}
