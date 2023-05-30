using SOLID1.Entity.Concrate;
using System.Linq.Expressions;

namespace SOLID1.DataAccess.Core.Abstract
{
    public interface IRepository<T> where T : BaseEntity
    {
       
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null);

        Task<T> FindAsync(object id);

        Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter);

        IQueryable<T> GetQuery();

        void Remove(T entity);

        Task CreateAsync(T entity);

        void Update(T entity, T unchanged);
    }
}
