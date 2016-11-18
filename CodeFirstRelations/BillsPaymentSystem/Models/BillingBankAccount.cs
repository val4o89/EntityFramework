using BillsPaymentSystem.Models.Billings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillsPaymentSystem.Models
{
    public class BillingBankAccount : BillingDetail
    {
        public string BankName { get; set; }

        public string SWIFTCode { get; set; }

        public virtual User Owner { get; set; }
    }
}
