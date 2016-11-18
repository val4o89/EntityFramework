using Entities.Context;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDs
{
    class Startup
    {
        static void Main(string[] args)
        {
            var context = new VechicleContect();

            var studentAndHomeork = context.Students.Select(x => new
            {
                StudentName = x.Name,
                Homeworks = x.Homeworks.Select(y => new
                {
                    y.ContentType,
                    y.Content
                })
    });

            foreach (var studentInfo in studentAndHomeork)
            {
                Console.WriteLine(studentInfo.StudentName);
                foreach (var homework in studentInfo.Homeworks)
                {
                    Console.WriteLine("    " + homework.Content + "    " + homework.ContentType);
                }
            }
        }
    }
}
