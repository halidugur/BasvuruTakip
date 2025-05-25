using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasvuruTakip.Models
{
    [Table("personeller")]
    public class Personel
    {


        [Key]
        [Column("id")]
        public long Id { get; set; }



        [Column("adisoyadi")]
        public string AdiSoyadi { get; set; } = string.Empty;



        [Column("ilid")]
        public long IlId { get; set; }



        [Column("ilceid")]
        public long IlceId { get; set; }



        [Column("cinsiyet")]
        public string? Cinsiyet { get; set; }



        [Column("dogumtarihi")]
        public DateTime DogumTarihi { get; set; } = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);




        [Column("aciklama")]
        public string? Aciklama { get; set; }



        public ICollection<PersonelIsBasvurusu> Basvurular { get; set; } = new List<PersonelIsBasvurusu>();


    }
}
