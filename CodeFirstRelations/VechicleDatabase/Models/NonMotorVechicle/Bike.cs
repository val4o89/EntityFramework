using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleDatabase.Models.NonMotorVechicle
{
    public class Bike : Vechicle
    {
        public int ShiftsCount { get; set; }

        public string Color { get; set; }
    }
}
