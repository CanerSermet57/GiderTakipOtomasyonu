using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GiderTakipOtomasyonu.Data
{
    public class KullaniciDbContext : DbContext
    {
        public DbSet<KullaniciDbClass> Kullanicilar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.; Database=GtoKullanicilar; Integrated Security=yes");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //******************** KullaniciDbClass Tablo Oluşturma İşlemleri ********************

            modelBuilder.Entity<KullaniciDbClass>().Property(x => x.adi)
                                                   .IsRequired()
                                                   .HasColumnName("Kullanıcı Adı")
                                                   .HasMaxLength(300);
            modelBuilder.Entity<KullaniciDbClass>().Property(x => x.mail)
                                                   .HasColumnName("Mail-Adresi")
                                                   .IsRequired()
                                                   .HasMaxLength(150);
            modelBuilder.Entity<KullaniciDbClass>().Property(x => x.sifre)
                                                   .IsRequired()
                                                   .HasColumnName("Şifre")
                                                   .HasMaxLength(30);

            //******************** KisiDbClass Tablo Oluşturma İşlemleri Bitişi ********************
        }
    }
}
