using CodingTestApp.DataAdapter.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodingTestApp.DataAdapter.Repository
{
    public abstract class RepositoryBase<TKey, TEntity> : ICrudRepository<TKey, TEntity>
    {
        public async Task<TKey> Create(TEntity entity)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));

            //Insert using DB context code will go from here

            throw new NotImplementedException();
        }

        public async Task<TEntity> Delete(TKey id)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));

            //Delete using DB context code will go from here

            throw new NotImplementedException();
        }

        public async Task<List<TEntity>> GetAll()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));

            //Get all using DB context code will go from here

            throw new NotImplementedException();
        }

        public async Task<TEntity> GetById(TKey id)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));

            //Find by id using DB context code will go from here

            throw new NotImplementedException();
        }

        public async Task Update(TEntity entity)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));

            //Update using DB context code will go from here

            throw new NotImplementedException();
        }
    }
}