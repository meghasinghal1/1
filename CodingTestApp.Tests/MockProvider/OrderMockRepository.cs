using CodingTestApp.DataAdapter.Contracts;
using CodingTestApp.DataAdapter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTestApp.Tests.MockProvider
{
    public class OrderMockRepository : IOrderRepository
    {
        private static Dictionary<decimal, OrderEntity> mockOrders;

        public OrderMockRepository()
        {
            mockOrders = new Dictionary<decimal, OrderEntity>();
        }

        public async Task<decimal> Create(OrderEntity entity)
        {
            if (mockOrders.Any())
            {
                entity.Id = mockOrders.Max(p => p.Key) + 1;
            }
            else
            {
                entity.Id = 1;
            }
            mockOrders.Add(entity.Id, entity);

            await Task.Delay(TimeSpan.FromSeconds(1));

            return entity.Id;
        }

        public async Task<OrderEntity> Delete(decimal id)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));

            //Delete using DB context code will go from here

            throw new NotImplementedException();
        }

        public async Task<List<OrderEntity>> GetAll()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));

            //Get all using DB context code will go from here

            throw new NotImplementedException();
        }

        public async Task<OrderEntity> GetById(decimal id)
        {
            if(!mockOrders.ContainsKey(id))
            {
                throw new KeyNotFoundException();
            }

            await Task.Delay(TimeSpan.FromSeconds(1));

            return mockOrders[id];
        }

        public async Task Update(OrderEntity entity)
        {
            if (!mockOrders.ContainsKey(entity.Id))
            {
                throw new KeyNotFoundException();
            }

            mockOrders[entity.Id] = entity;

            await Task.Delay(TimeSpan.FromSeconds(1));
        }
    }
}