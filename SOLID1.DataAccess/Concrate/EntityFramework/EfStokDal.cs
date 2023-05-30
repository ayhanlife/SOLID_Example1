using Microsoft.EntityFrameworkCore;
using SOLID1.DataAccess.Abstract;
using SOLID1.DataAccess.Core.Concrate;
using SOLID1.Entity.Concrate;

namespace SOLID1.DataAccess.Concrate.EntityFramework
{
    public class EfStokDal : Repository<Stok>, IStokDal
    {
        private readonly Context context;
        public EfStokDal(Context context) : base(context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Stok>> StokWithCategoryList()
        {
            var query = context.Set<Stok>().AsQueryable();


            return await query.Include(x => x.Kategori).Include(x => x.UrunAciklama).ToListAsync();
            //return _mapper.Map<List<AdvertisementAppUserListDto>>(list);


            //return await context.Stok.Include(x => x.Kategori).Include(x => x.UrunAciklama).ToListAsync();
        }
    }
}
