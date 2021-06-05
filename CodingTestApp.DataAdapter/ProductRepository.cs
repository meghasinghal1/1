using CodingTestApp.DataAdapter.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodingTestApp.DataAdapter
{
    public class ProductRepository : ICrudRepository<ProductEntity>
    {
        public async Task<int> Create(ProductEntity entity)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));

            //Insert using DB context code will go from here

            throw new NotImplementedException();
        }

        public async Task<ProductEntity> Delete(int id)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));

            //Delete using DB context code will go from here

            throw new NotImplementedException();
        }

        public async Task<List<ProductEntity>> GetAll()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));

            //Get all using DB context code will go from here

            throw new NotImplementedException();
        }

        public async Task<ProductEntity> GetById(int id)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));

            //Find by id using DB context code will go from here

            throw new NotImplementedException();
        }

        public async Task<ProductEntity> Update(ProductEntity entity)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));

            //Update using DB context code will go from here

            throw new NotImplementedException();
        }
    }
}