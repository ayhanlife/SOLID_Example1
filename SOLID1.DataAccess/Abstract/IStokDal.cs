using SOLID1.DataAccess.Core.Abstract;
using SOLID1.Entity.Concrate;

namespace SOLID1.DataAccess.Abstract
{
    public interface IStokDal : IRepository<Stok>
    {
        Task<IEnumerable<Stok>> StokWithCategoryList();
    }
}
