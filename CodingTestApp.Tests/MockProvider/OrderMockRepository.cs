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
        private static List<OrderEntity> mockOrders;

        public OrderMockRepository()
        {
            mockOrders = new List<OrderEntity>();
        }

        public async Task<decimal> Create(OrderEntity entity)
        {
            if (mockOrders.Any())
            {
                entity.Id = mockOrders.Max(p => p.Id);
            }
            else
            {
                entity.Id = 1;
            }
            mockOrders.Add(entity);

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
            var order = mockOrders.FirstOrDefault(o => o.Id == id);

            if(order == null)
            {
                throw new KeyNotFoundException();
            }

            await Task.Delay(TimeSpan.FromSeconds(1));

            return order;
        }

        public async Task<OrderEntity> Update(OrderEntity entity)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));

            //Update using DB context code will go from here

            throw new NotImplementedException();
        }
    }
}