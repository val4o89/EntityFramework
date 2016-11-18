using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleDatabase.Models.MotorVechicles
{
    public abstract class Ship : MotorVechicle
    {
        public string Nationality { get; set; }

        public string CaptainName { get; set; }

        public int SizeOfShipCrew { get; set; }
    }
}
