using BillsPaymentSystem.Models.Billings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillsPaymentSystem.Models
{
    public class BillingBankCard : BillingDetail
    {
        public string CardType { get; set; }

        public int ExpirationMonth { get; set; }

        public int ExpirationYear { get; set; }

        public virtual User Owner { get; set; }
    }
}
