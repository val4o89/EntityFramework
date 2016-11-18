using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Student
    {
        public Student()
        {
            this.Courses = new HashSet<Course>();
            this.Homeworks = new HashSet<Homework>();
            this.Friends = new HashSet<Student>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime? RegistrationDate { get; set; }

        public DateTime? BirthDate { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<Homework> Homeworks { get; set; }

        public virtual ICollection<Student> Friends { get; set; }


    }   
}
