using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDatabase.Models
{
    public class Payment
    {
        public int Id { get; set; }

        public DateTime PaymentDate { get; set; }

        public Customer Customer { get; set; }

        public DateTime FirstDateOccupied { get; set; }

        public DateTime LastDateOccupied { get; set; }

        public int TotalDays { get; set; }

        public decimal AmountCharge { get; set; }

        public decimal TaxRate { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal PaymentTotal { get; set; }

        public string Notes { get; set; }
    }
}
//Id, , AccountNumber, FirstDateOccupied, LastDateOccupied, TotalDays, AmountCharged, TaxRate, TaxAmount, PaymentTotal, Notes