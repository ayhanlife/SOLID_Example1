namespace SOLID1.Entity.Concrate
{
    public class Stok : BaseEntity
    {
        public string Baslik { get; set; } = String.Empty;
        public string Kod { get; set; } = String.Empty;
        public string Barkod { get; set; } = String.Empty;

        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }

        //public List<UrunAciklama>? UrunAciklama { get; set; }

        public int? UrunAciklamaId { get; set; }
        public UrunAciklama? UrunAciklama { get; set; }


        public int? VitrinId { get; set; }
        public Vitrin? Vitrin { get; set; }


        public int? EnCokSatanUrunlerId { get; set; }
        public EnCokSatanUrunler? EnCokSatanUrunler { get; set; }


        public int? TavsiyeEdilenUrunlerId { get; set; }
        public TavsiyeEdilenUrunler? TavsiyeEdilenUrunler { get; set; }
    }
}
