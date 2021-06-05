using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodingTestApp.DataAdapter
{
    public interface ICrudRepository<TEntity>
    {
        Task<int> Create(TEntity entity);

        Task<TEntity> Update(TEntity entity);

        Task<TEntity> GetById(int id);

        Task<List<TEntity>> GetAll();

        Task<TEntity> Delete(int id);
    }
}