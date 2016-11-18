using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleDatabase.Models.MotorVechicles
{
    public abstract class Carriage
    {
        public int Id { get; set; }

        public Train Train { get; set; }

        public int PassengerSeatsCapacity { get; set; }
    }
}
