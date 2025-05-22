using Microsoft.EntityFrameworkCore;
using BasvuruTakip.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace BasvuruTakip.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Personel> Personeller { get; set; }
        public DbSet<PersonelIsBasvurusu> PersonelIsBasvurulari { get; set; }
        public DbSet<Il> Iller { get; set; }
        public DbSet<Ilce> Ilceler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ilce>().HasKey(i => i.IlceId);
            modelBuilder.Entity<Il>().HasKey(i => i.Id);
            modelBuilder.Entity<Personel>().HasKey(p => p.Id);
            modelBuilder.Entity<PersonelIsBasvurusu>().HasKey(b => b.Id);

            modelBuilder.Entity<Personel>()
                .HasMany(p => p.Basvurular)
                .WithOne(b => b.Personel)
                .HasForeignKey(b => b.PersonelId);
        }
    }
}
