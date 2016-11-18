using BillsPaymentSystem.Models;
using BillsPaymentSystem.Models.Billings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillsPaymentSystem
{
    public class User
    {
        public User()
        {
            this.BankCards = new HashSet<BillingBankCard>();
            this.BankAccount = new HashSet<BillingBankAccount>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public virtual ICollection<BillingBankCard> BankCards { get; set; }
        public virtual ICollection<BillingBankAccount> BankAccount { get; set; }
    }
}
