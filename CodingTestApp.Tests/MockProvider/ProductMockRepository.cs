using CodingTestApp.DataAdapter;
using CodingTestApp.DataAdapter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTestApp.Tests.MockProvider
{
    public class ProductMockRepository : ICrudRepository<ProductEntity>
    {
        private static List<ProductEntity> mockProducts;

        public ProductMockRepository()
        {
            mockProducts = new List<ProductEntity>();
        }

        public async Task<int> Create(ProductEntity entity)
        {
            entity.Id = mockProducts.Max(p => p.Id);
            mockProducts.Add(entity);

            await Task.Delay(TimeSpan.FromSeconds(1));

            return entity.Id;
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