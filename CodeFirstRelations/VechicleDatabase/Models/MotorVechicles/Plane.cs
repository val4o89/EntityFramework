using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleDatabase.Models.MotorVechicles
{
    public class Plane : MotorVechicle
    {
        public string AirlineOwner { get; set; }

        public string Color { get; set; }

        public int PassangerCapacity { get; set; }
    }
}
