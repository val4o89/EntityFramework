using Entities.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDsCoursesResourses
{
    class Startup
    {
        static void Main(string[] args)
        {
            var context = new VechicleContect();

            //var coursesResourses = context.Courses.Select(x => new
            //{
            //    x.Name,
            //    x.Description,
            //    Resourses = x.Resourses
            //});

            //foreach (var cr in coursesResourses)
            //{
            //    Console.WriteLine(cr.Name);

            //    foreach (var res in cr.Resourses)
            //    {
            //        Console.WriteLine($"    {res.Name} {res.ResourseType}");
            //    }
            //}

            var date = DateTime.Parse(Console.ReadLine());

            var courses = context.Courses.Where(x => x.StartDate < date && x.EndDate > date).Select(x =>
            new
            {
                x.Name,
                x.StartDate,
                x.EndDate,
                DateDiff = SqlFunctions.DateDiff("Day", x.StartDate, x.EndDate),
                NumOfStuds = x.Students.Count(),
            }).OrderByDescending(x => x.NumOfStuds).ThenByDescending(x => x.DateDiff);

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Name} {course.NumOfStuds} {course.DateDiff} {course.StartDate} {course.EndDate}");
            }


        }
    }
}
