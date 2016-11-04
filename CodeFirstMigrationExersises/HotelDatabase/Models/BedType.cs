using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDatabase.Models
{
    public class BedType
    {
        public int Id { get; set; }

        [Column("BedType")]
        public string Type { get; set; }

        public string Note { get; set; }
    }
}
