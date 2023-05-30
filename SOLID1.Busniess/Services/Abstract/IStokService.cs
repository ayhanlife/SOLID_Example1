using SOLID1.Entity.Concrate;
using SOLID1.Entity.DTOs.Stok;

namespace SOLID1.Business.Services.Abstract
{
    public interface IStokService
    {
        Task<IEnumerable<StokKategoriUrunAciklamaDTO>> StokKategoriUrunAciklamaListesi();
    }
}
