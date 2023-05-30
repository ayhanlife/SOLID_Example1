using Microsoft.EntityFrameworkCore;
using SOLID1.Entity.Concrate;

namespace SOLID1.DataAccess
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }



        public DbSet<EnCokSatanUrunler> EnCokSatanUrunler { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Sepet> Sepet { get; set; }
        public DbSet<Stok> Stok { get; set; }
        public DbSet<TavsiyeEdilenUrunler> TavsiyeEdilenUrunler { get; set; }
        public DbSet<UrunAciklama> UrunAciklama { get; set; }
        public DbSet<Vitrin> Vitrin { get; set; }
        // public DbSet<Stok> Stok { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategori>().HasData(
                new Kategori
                {
                    Id = 1,
                    Adi = "Siyah Zeytin",
                },
                new Kategori
                {
                    Id = 2,
                    Adi = "Yeşil Zeytin",
                },
                new Kategori
                {
                    Id = 3,
                    Adi = "Zeytin Yağı",
                }
            );



            modelBuilder.Entity<Stok>().HasData(
                new Stok
                {
                    Id = 1,
                    KategoriId = 1,
                    UrunAciklamaId = 1,
                    Kod = "TDR01",
                    Baslik = "Taş Baskı Siyah Zeytin",
                    Barkod = "8698943124586"
                },
                new Stok
                {
                    Id = 2,
                    KategoriId = 1,
                    UrunAciklamaId = 2,
                    Kod = "TDR02",
                    Baslik = "Gold Siyah Zeytin",
                    Barkod = "8698943124587"
                },
                new Stok
                {
                    Id = 3,
                    KategoriId = 1,
                    UrunAciklamaId = 3,
                    Kod = "TDR03",
                    Baslik = "Sele Siyah Zeytin",
                    Barkod = "8698943124588"
                },
                new Stok
                {
                    Id = 4,
                    KategoriId = 2,
                    Kod = "TDR04",
                    Baslik = "Gemlik Kızıl Yeşil Zeytin",
                    Barkod = "8698943124590"
                },
                new Stok
                {
                    Id = 5,
                    KategoriId = 2,
                    Kod = "TDR05",
                    Baslik = "Edremit Yeşil Zeytin",
                    Barkod = "8698943124590"
                },
                new Stok
                {
                    Id = 6,
                    KategoriId = 2,
                    Kod = "TDR06",
                    Baslik = "Bademli Yeşil Zeytin",
                    Barkod = "8698943124591"
                },
                new Stok
                {
                    Id = 7,
                    KategoriId = 3,
                    Kod = "TDR07",
                    Baslik = "Naturel Sızma Zeytin Yağı",
                    Barkod = "8698943124592"
                },
                new Stok
                {
                    Id = 8,
                    KategoriId = 3,
                    Kod = "TDR09",
                    Baslik = "Taş Baskı Sızma Zeytin Yağı",
                    Barkod = "8698943124593"
                },
                new Stok
                {
                    Id = 9,
                    KategoriId = 3,
                    Kod = "TDR10",
                    Baslik = "İlk Aşk Zeytin Yağı",
                    Barkod = "86989431245494"
                }
            );

            modelBuilder.Entity<UrunAciklama>().HasData(
                new UrunAciklama
                {
                    Id = 1,
                    Aciklama = "Taş baskı siyah zeytin gemligin cocudur",
                    Brim = "ADET",
                    Tutar = 500
                },
                new UrunAciklama
                {
                    Id = 2,
                    Aciklama = "Gold siyah zeytin gemligin altınıdır",
                    Brim = "ADET",
                    Tutar = 200
                },
                new UrunAciklama
                {
                    Id = 3,
                    Aciklama = "Sele   zeytin gemligin fakirlerine hitap eder",
                    Brim = "ADET",
                    Tutar = 100
                }
            ); ;
        }





    }
}
