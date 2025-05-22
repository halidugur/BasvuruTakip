using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasvuruTakip.Models
{
    [Table("ilceler")]
    public class Ilce
    {
        [Column("ilid")]
        public long IlId { get; set; }

        [Key]
        [Column("ilceid")]
        public long IlceId { get; set; }

        [Column("adi")]
        public string Adi { get; set; } = string.Empty;
    }
}
