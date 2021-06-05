using CodingTestApp.DataAdapter.Contracts;
using CodingTestApp.DataAdapter.Entities;

namespace CodingTestApp.DataAdapter.Repository
{
    public class ProductRepository : RepositoryBase<int, ProductEntity>, IProductRepository
    {

    }
}