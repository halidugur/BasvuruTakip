using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasvuruTakip.Models
{
    [Table("personelisbasvurulari")]
    public class PersonelIsBasvurusu
    {


        [Key]
        [Column("id")]
        public int Id { get; set; }



        [Column("personelid")]
        public long PersonelId { get; set; }



        [Column("basvurutarihi")]
        public DateTime BasvuruTarihi { get; set; }



        [Column("ilid")]
        public long IlId { get; set; }



        [Column("seyahatengeliyok")]
        public bool SeyahatEngeliYok { get; set; }



        [Column("isyeriadi")]
        public string IsyeriAdi { get; set; } = string.Empty;



        [Column("pozisyon")]
        public string Pozisyon { get; set; } = string.Empty;



        [Column("aciklama")]
        public string? Aciklama { get; set; }



        public Personel? Personel { get; set; }


    }
}
