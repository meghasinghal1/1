using CodingTestApp.DataAdapter.Entities;

namespace CodingTestApp.DataAdapter.Contracts
{
    public interface IProductRepository : ICrudRepository<int, ProductEntity>
    {

    }
}