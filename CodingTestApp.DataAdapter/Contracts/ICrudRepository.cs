using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodingTestApp.DataAdapter.Contracts
{
    public interface ICrudRepository<TKey, TEntity>
    {
        Task<TKey> Create(TEntity entity);

        Task<TEntity> Update(TEntity entity);

        Task<TEntity> GetById(TKey id);

        Task<List<TEntity>> GetAll();

        Task<TEntity> Delete(TKey id);
    }
}