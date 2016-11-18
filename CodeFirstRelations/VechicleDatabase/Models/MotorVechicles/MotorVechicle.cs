using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleDatabase.Models.MotorVechicles
{
    public abstract class MotorVechicle : Vechicle
    {
        public int NumberOfEngines { get; set; }

        public string EngineType { get; set; }

        public double TankCapacity { get; set; }
    }
}
