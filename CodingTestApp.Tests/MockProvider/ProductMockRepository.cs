using CodingTestApp.DataAdapter.Contracts;
using CodingTestApp.DataAdapter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTestApp.Tests.MockProvider
{
    public class ProductMockRepository : IProductRepository
    {
        private static List<ProductEntity> mockProducts;

        public ProductMockRepository()
        {
            mockProducts = new List<ProductEntity>();
        }

        public async Task<int> Create(ProductEntity entity)
        {
            if (mockProducts.Any())
            {
                entity.Id = mockProducts.Max(p => p.Id) + 1;
            }
            else
            {
                entity.Id = 1;
            }
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
            var product = mockProducts.FirstOrDefault(o => o.Id == id);

            if (product == null)
            {
                throw new KeyNotFoundException();
            }

            await Task.Delay(TimeSpan.FromSeconds(1));

            return product;
        }

        public async Task Update(ProductEntity entity)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));

            //Update using DB context code will go from here

            throw new NotImplementedException();
        }
    }
}