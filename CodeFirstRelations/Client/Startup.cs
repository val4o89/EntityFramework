using Entities.Context;
using Entities.Enums;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VechicleDatabase.Models.MotorVechicles;

namespace Client
{
    public class Startup
    {
        static void Main()
        {

            var context = new VechicleContect();
            //var student = new Student { Name = "Kolio", RegistrationDate = new DateTime(1998, 01, 01) };
            //var course = new Course { Name = "C# OOP Advanced", Price = 390, StartDate = new DateTime(2014, 09, 09), Description = "C# course" };
            //var resourse = new Resourse { Name = "Lab", ResourseType = ResourseType.Document, Course = course };
            //var homework = new Homework { Content = "This is his homework", ContentType = ContentType.ZIP, SubmissionDate = new DateTime(2012, 10, 10), Course = course, Student = student };

            //student.Courses.Add(course);
            //course.HomeworkSubmissions.Add(homework);
            //course.Resourses.Add(resourse);
            //course.Students.Add(student);

            //context.Students.AddOrUpdate(x => x.Name, student);
            //context.Courses.AddOrUpdate(x => x.Name, course);
            //context.Resourses.AddOrUpdate(x => x.Name, resourse);
            //context.Homeworks.AddOrUpdate(x => x.Content, homework);

            var car = new Car { NumberOfDoors = 4, HasInsurance = true };
            var plane = new Plane { PassangerCapacity = 21 };
        }
    }
}
