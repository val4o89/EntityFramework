using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDatabase.Models
{
    public abstract class Account
    {
        public int Id { get; set; }
        
        public decimal Ballance { get; set; }
    }
}
