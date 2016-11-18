using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleDatabase.Models.MotorVechicles
{
    public class Train : MotorVechicle
    {
        public int NumberOfCariges { get; set; }

        public ICollection<Carriage> ListOfCarriges { get; set; }

        public Locomotive Locomotive { get; set; }
    }
}
