using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleDatabase.Models
{
    public abstract class Vechicle
    {
        public int Id { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public int MaxSpeed { get; set; }
    }
}
