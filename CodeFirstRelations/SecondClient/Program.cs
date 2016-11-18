using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VechicleDatabase.Context;
using VechicleDatabase.Models.MotorVechicles;

namespace SecondClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            var context = new VechicleContect();

            context.Vechicles.Add(new Car { });
        }
    }
}
