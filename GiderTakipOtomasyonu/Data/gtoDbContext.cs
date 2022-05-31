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





        }

    }
}
