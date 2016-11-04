using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDatabase.Models
{
    [Table("RoomStatus")]
    public class RoomStatus
    {
        public int Id { get; set; }

        [Column("roomStatus")]
        public string Status { get; set; }

        public string Notes { get; set; }
    }
}
