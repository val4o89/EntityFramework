using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Resourse
    {
        public Resourse()
        {
            this.Licenses = new HashSet<License>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ResourseType ResourseType { get; set; }

        public string URL { get; set; }

        public Course Course { get; set; }

        public virtual ICollection<License> Licenses { get; set; }
    }
}
