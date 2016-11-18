using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleDatabase.Models.MotorVechicles
{
    public class Car : MotorVechicle
    {
        public int NumberOfDoors { get; set; }

        public bool HasInsurance { get; set; }
    }
}
