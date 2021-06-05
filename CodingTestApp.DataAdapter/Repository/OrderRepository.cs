using CodingTestApp.DataAdapter.Contracts;
using CodingTestApp.DataAdapter.Entities;

namespace CodingTestApp.DataAdapter.Repository
{
    public class OrderRepository : RepositoryBase<decimal, OrderEntity>, IOrderRepository
    {

    }
}