using AutoMapper;
using SOLID1.Entity.Concrate;
using SOLID1.Entity.DTOs.KategoriDtos;
using SOLID1.Entity.DTOs.Stok;
using SOLID1.Entity.DTOs.UrunAciklamaDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID1.Business.Mapper.AutoMapper
{
    public class AutoMapperStok : Profile
    {
        public AutoMapperStok()
        {
            CreateMap<Stok, StokKategoriUrunAciklamaDTO>().ReverseMap();
            CreateMap<Kategori, KategoriListDto>().ReverseMap();
            CreateMap<UrunAciklama, UrunAciklamaListDto>().ReverseMap();
        }
    }
}
