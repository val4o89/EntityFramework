﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDatabase.Models
{
    public class Occupancy
    {
        public int Id { get; set; }

        public DateTime DateOccupied { get; set; }

        public Customer Accountnumber { get; set; }

        public Room Room { get; set; }

        public decimal RateApplied { get; set; }

        public decimal PhoneCharge { get; set; }

        public string Notes { get; set; }
    }
}
//Id, DateOccupied, AccountNumber, RoomNumber, RateApplied, PhoneCharge, Notes)