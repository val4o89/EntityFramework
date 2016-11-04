using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gringots.Models
{
    [ComplexType]
    public class MagicWand
    {
        [MaxLength(100)]
        [Column("MagicWandCreator")]
        public string MagicWandCreator { get; set; }

        [Range(1, short.MaxValue)]
        [Column("MagicWandSize")]
        public short? MagicWandSize { get; set; }
    }
}
