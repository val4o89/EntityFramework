using System.ComponentModel.DataAnnotations;

namespace Gringots.Models
{
    public class WizzardDeposit
    {
        [Key]
        public int Id { get; set; }

        public Wizzard Wizard { get; set; }

        public MagicWand MagicWand { get; set; }

        public Deposit Deposit { get; set; }
    }
}
