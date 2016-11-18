namespace Entities.Migrations
{
    using Context;
    using Enums;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<VechicleContect>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(VechicleContect context)
        {
            var student = new Student { Name = "Ganio", RegistrationDate = new DateTime(1989, 01, 01) };
            var course = new Course { Name = "Entity Framework", Price = 390, StartDate = new DateTime(2016, 09, 09), Description = "C# course" };
            var resourse = new Resourse { Name = "Intro video", ResourseType = ResourseType.Video, Course = course };
            var homework = new Homework { Content = "This is my homework", ContentType = ContentType.Application, SubmissionDate = new DateTime(2016, 10, 10), Course = course, Student = student };

            student.Courses.Add(course);
            course.HomeworkSubmissions.Add(homework);
            course.Resourses.Add(resourse);
            course.Students.Add(student);

            context.Students.AddOrUpdate(x => x.Name, student);
            context.Courses.AddOrUpdate(x => x.Name, course);
            context.Resourses.AddOrUpdate(x => x.Name, resourse);
            context.Homeworks.AddOrUpdate(x => x.Content, homework);
        }
    }
}
