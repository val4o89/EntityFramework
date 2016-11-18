using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleDatabase.Models.MotorVechicles
{
    public class Locomotive
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public double Power { get; set; }

        public Train Train { get; set; }
    }
}
