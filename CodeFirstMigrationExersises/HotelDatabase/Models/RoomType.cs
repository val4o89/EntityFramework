using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDatabase.Models
{
    public class RoomType
    {
        public int Id { get; set; }

        [Column("RoomType")]
        public string Type { get; set; }

        public string Notes { get; set; }
    }
}
