using CodingTestApp.Business.DomainModels.Product;
using CodingTestApp.DataAdapter;
using CodingTestApp.DataAdapter.Entities;
using System;
using System.Threading.Tasks;

namespace CodingTestApp.Business.Services
{
    public class ProductService
    {
        private readonly ProductRepository productRepository;
        private readonly UserIdentityModel userIdentity;

        public ProductService(
            ProductRepository productRepository,
            UserIdentityModel userIdentity)
        {
            this.productRepository = productRepository;
            this.userIdentity = userIdentity;
        }

        public async Task<int> Create(ProductCreateModel model)
        {
            var product = await productRepository.Create(new ProductEntity
            {
                CategoryType = (int)model.CategoryType,
                Name = model.Name,
                DeliveryType = (int)model.DeliveryType,
                CreatedDate = DateTime.UtcNow,
                CreatedBy = userIdentity.LoggedInUserId
            });

            return product.Id;
        }
    }
}