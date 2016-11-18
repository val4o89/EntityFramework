using Entities.Attributes;
using System.Collections;
using System.Collections.Generic;

namespace Entities.Models
{
    public class Tag
    {
        public Tag()
        {
            this.Albums = new HashSet<Album>();
        }

        public int Id { get; set; }

        [Tag]
        public string Content { get; set; }

        public ICollection<Album> Albums { get; set; }
    }
}