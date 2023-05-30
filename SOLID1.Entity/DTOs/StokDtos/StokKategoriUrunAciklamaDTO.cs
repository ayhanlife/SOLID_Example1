using SOLID1.Entity.Concrate;
using SOLID1.Entity.DTOs.KategoriDtos;
using SOLID1.Entity.DTOs.UrunAciklamaDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID1.Entity.DTOs.Stok
{
    public class StokKategoriUrunAciklamaDTO
    {
        public int Id { get; set; }
        public string Baslik { get; set; } = string.Empty;
        public string Kod { get; set; } = string.Empty;
        public string Barkod { get; set; } = string.Empty;


        public int KategoriId { get; set; }
        public KategoriListDto Kategori { get; set; }
        public int UrunAciklamaId { get; set; }
        public UrunAciklamaListDto UrunAciklama { get; set; }

    }
}
