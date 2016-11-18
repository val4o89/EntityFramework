using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillsPaymentSystem.Models.Billings
{
    public abstract class BillingDetail
    {
        public int Id { get; set; }

        public int BillingNumber { get; set; }
    }
}
