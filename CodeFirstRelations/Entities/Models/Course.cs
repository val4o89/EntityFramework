using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Course
    {
        public Course()
        {
            this.Students = new HashSet<Student>();
            this.Resourses = new HashSet<Resourse>();
            this.HomeworkSubmissions = new HashSet<Homework>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? StartDate { get; set; }

        public string Description { get; set; }

        public DateTime? EndDate { get; set; }

        public decimal Price { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public virtual ICollection<Resourse> Resourses { get; set; }

        public virtual ICollection<Homework> HomeworkSubmissions { get; set; }
    }
}
