using System.Collections;
using System.Collections.Generic;

namespace Entities.Models
{
    public class Album
    {
        public Album()
        {
            this.Pictures = new HashSet<Picture>();
            this.Tags = new HashSet<Tag>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string BackgroundColor { get; set; }

        public bool IsPublic { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }

      //  public virtual ICollection<OwnersViewers> OwnersViewers { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}