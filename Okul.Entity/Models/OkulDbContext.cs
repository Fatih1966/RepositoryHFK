using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Entity.Models
{
    public class OkulDbContext:DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ogretmen> Ogretmenler { get; set; }
        public DbSet<Sinif> Siniflar { get; set; }
        public DbSet<Brans> Branslar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=FK-MSI\SQLEXPRESS;Database = CoreOkul;Trusted_Connection = true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*Ogrenci Tablosu icin gerekli proplar*/
            modelBuilder.Entity<Ogrenci>().Property(p => p.CepTelefonu).HasMaxLength(15);
            modelBuilder.Entity<Ogrenci>().Property(p => p.TCKimlik).HasMaxLength(11);
            modelBuilder.Entity<Ogrenci>().Property(p => p.Ad).HasMaxLength(20);
            modelBuilder.Entity<Ogrenci>().Property(p => p.Soyad).HasMaxLength(20);
            modelBuilder.Entity<Ogrenci>().Property(p => p.Email).HasMaxLength(100);


            modelBuilder.Entity<Ogretmen>().Property(p => p.CepTelefonu).HasMaxLength(15);
            modelBuilder.Entity<Ogretmen>().Property(p => p.TCKimlik).HasMaxLength(11);
            modelBuilder.Entity<Ogretmen>().Property(p => p.Ad).HasMaxLength(20);
            modelBuilder.Entity<Ogretmen>().Property(p => p.Soyad).HasMaxLength(20);
            modelBuilder.Entity<Ogretmen>().Property(p => p.Email).HasMaxLength(100);

            modelBuilder.Entity<Brans>().Property(p => p.BransAdi).HasMaxLength(50);

            modelBuilder.Entity<Sinif>().Property(p => p.SinifAdi).HasMaxLength(50);
        }


    }
}
