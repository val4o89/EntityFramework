using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gringots.Models
{
    [ComplexType]
    public class Deposit
    {
        [MaxLength(20)]
        [Column("DepositGroup")]
        public string DepositGroup { get; set; }

        [Column("DepositStartDate")]
        public DateTime? DepositStartDate { get; set; }

        [Column("DepositAmount")]
        public decimal? DepositAmount { get; set; }

        [Column("DepositInterest")]
        public decimal? DepositInterest { get; set; }

        [Column("DepositCharge")]
        public decimal? DepositCharge { get; set; }

        [Column("DepositExpirationDate")]
        public DateTime? DepositExpirationDate { get; set; }

        [Column("IsDepositExpired")]
        public bool? IsDepositExpired { get; set; }
    }
}
