using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Homework
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public ContentType ContentType { get; set; }

        public DateTime? SubmissionDate { get; set; }

        public virtual Student Student { get; set; }

        public virtual Course Course { get; set; }
    }
}
