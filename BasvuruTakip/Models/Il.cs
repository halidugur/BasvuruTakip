using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasvuruTakip.Models
{
    [Table("iller")]
    public class Il
    {


        [Key]
        [Column("id")]
        public long Id { get; set; }



        [Column("adi")]
        public string Adi { get; set; } = string.Empty;
    }
}
