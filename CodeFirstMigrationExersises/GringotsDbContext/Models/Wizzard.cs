using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gringots.Models
{
    [ComplexType]
    public class Wizzard
    {
        [Column("FirstName")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(60)]
        [Column("LastName")]
        public string LastName { get; set; }

        [MaxLength(1000)]
        [Column("Notes")]
        public string Notes { get; set; }

        [Range(0, int.MaxValue)]
        [Column("Age")]
        public int? Age { get; set; }
    }
}
