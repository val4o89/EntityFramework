using Entities.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdCRUD
{
    class Startup
    {
        static void Main()
        {
            var context = new VechicleContect();

            var courses = context.Courses.Where(c => c.Resourses.Count > 5).Select(c => new
            {
                c.Name,
                c.Description,
                c.Resourses,
                c.StartDate
            }).OrderByDescending(x => x.Resourses.Count).ThenByDescending(x => x.StartDate);


        }
    }
}
