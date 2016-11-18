using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Viewer
    {
        private ICollection<Album> albums;

        public Viewer()
        {
            this.albums = new HashSet<Album>();
        }

        public int Id { get; set; }

        public IReadOnlyCollection<Album> Albums
        {
            get
            {
                return (IReadOnlyCollection<Album>)this.albums;
            }
        }
    }
}
