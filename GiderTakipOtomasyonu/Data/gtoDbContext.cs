using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GiderTakipOtomasyonu.Data
{
    public class gtoDbContext : DbContext
    {
        public DbSet<KisiDbClass> Kisiler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.; Database=GTODB; Integrated Security=yes");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // KisiDbClass Tablo Oluşturma İşlemleri

            modelBuilder.Entity<KisiDbClass>().Property(x => x.bilgi)
                                              .HasColumnName("Bilgi")
                                              .HasMaxLength(300);
            modelBuilder.Entity<KisiDbClass>().Property(x => x.adres)
                                              .HasColumnName("Adres")
                                              .IsRequired()
                                              .HasMaxLength(150);
            modelBuilder.Entity<KisiDbClass>().Property(x => x.faksNo)
                                              .HasColumnName("Faks No")
                                              .HasMaxLength(11);
            modelBuilder.Entity<KisiDbClass>().Property(x => x.telNo)
                                              .IsRequired()
                                              .HasColumnName("Telefon No")
                                              .HasMaxLength(11);
            modelBuilder.Entity<KisiDbClass>().Property(x => x.adi)
                                              .IsRequired()
                                              .HasColumnName("Adı")
                                              .HasMaxLength(25);
            modelBuilder.Entity<KisiDbClass>().Property(x => x.borc)
                                              .HasColumnName("Borc");
            modelBuilder.Entity<KisiDbClass>().Property(x => x.alacak)
                                              .HasColumnName("Alacak");

            //******************** KisiDbClass Tablo Oluşturma İşlemleri Bitişi ********************

            // KisiDbClass Tablo Test Verisi Ekleme İşlemleri

            modelBuilder.Entity<KisiDbClass>().HasData(new KisiDbClass { id = 1, borc = 501, alacak = 15100, bilgi = "Dürüst Biri", adres = "Elazığ Merkez", faksNo = "06665555555", telNo = "01472536980", adi = "Durmuş Kahraman" });
            modelBuilder.Entity<KisiDbClass>().HasData(new KisiDbClass { id = 2, borc = 540, alacak = 10560, bilgi = "İyi Biri", adres = "Ankara Kızılay", faksNo = "04565555555", telNo = "03255698547", adi = "Dilek Yılmaz" });
            modelBuilder.Entity<KisiDbClass>().HasData(new KisiDbClass { id = 3, borc = 589, alacak = 10651, bilgi = "Güvenilmez Biri", adres = "Elazığ Maden", faksNo = "02585555555", telNo = "01231471558", adi = "Caner Olmuş" });
            modelBuilder.Entity<KisiDbClass>().HasData(new KisiDbClass { id = 4, borc = 50, alacak = 5416, bilgi = "Borç Verilmez Biri", adres = "İstanbul Gaziosmanpaşa", faksNo = "02125555555", telNo = "02582695847", adi = "Emre Durhan" });
            modelBuilder.Entity<KisiDbClass>().HasData(new KisiDbClass { id = 5, borc = 500, alacak = 5510, bilgi = "Herhangi Biri", adres = "İstanbul Aksaray", faksNo = "07895555555", telNo = "04568524568", adi = "Merve Kum" });
            //********** KisiDbClass Tablo Test Verisi Ekleme İşlemleri Bitişi **************



        }

    }
}
