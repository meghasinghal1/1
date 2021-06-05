using CodingTestApp.DataAdapter.Entities;

namespace CodingTestApp.DataAdapter.Contracts
{
    public interface IOrderRepository : ICrudRepository<decimal, OrderEntity>
    {

    }
}