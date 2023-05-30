using AutoMapper;
using SOLID1.Business.Services.Abstract;
using SOLID1.DataAccess.Abstract;
using SOLID1.Entity.DTOs.Stok;

namespace SOLID1.Business.Services.Concrate
{
    public class StokService : IStokService
    {
        private readonly IStokDal _stokRespository;
        private readonly IMapper _mapper;
        public StokService(IStokDal stokRespository, IMapper _mapper)
        {
            this._stokRespository = stokRespository;
            this._mapper = _mapper;
        }

        public async Task<IEnumerable<StokKategoriUrunAciklamaDTO>> StokKategoriUrunAciklamaListesi()
        {
            return _mapper.Map<IEnumerable<StokKategoriUrunAciklamaDTO>>(await _stokRespository.StokWithCategoryList());
        }
    }
}
