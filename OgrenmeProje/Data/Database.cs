using Microsoft.EntityFrameworkCore;
using OgrenmeProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenmeProje.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<SiparisItem> Siparisitemler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategori { get; set; }

        protected override void OnConfiguring( DbContextOptionsBuilder options)
        {
            { 

            }
        }

    }
}
