using CodingTestApp.Business.DomainModels.Order;
using CodingTestApp.Business.DomainModels.Product;
using CodingTestApp.Business.Services;
using CodingTestApp.Tests.MockProvider;
using FluentAssertions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace CodingTestApp.Tests
{
    public class OrderServiceTests
    {
        private readonly ProductService productService;
        
        private readonly OrderService orderService;

        public OrderServiceTests()
        {
            var userIdentityModel = new UserIdentityModel
            {
                LoggedInUserId = 1,
                LoggedInUserEmail = "ved_singhal@yahoo.com"
            };

            productService = new ProductService(new ProductMockRepository(), userIdentityModel);

            orderService = new OrderService(new OrderMockRepository(), new ProductMockRepository(), userIdentityModel);
        }

        [Fact]
        public async Task OrderServiceTests_HappyPath_ShouldCreateAnOrder()
        {
            //Arrange
            var product1Id = await CreateProduct("Product 1", ProductCategoryType.Book, ProductDeliveryType.Physical);
            var product2Id = await CreateProduct("Product 1", ProductCategoryType.Book, ProductDeliveryType.Physical);

            var orderRequest = new OrderCreateModel
            {
                Products = new List<int>
                {
                    product1Id,
                    product2Id
                }
            };

            //Act
            var orderId = await orderService.Create(orderRequest);

            //Assert
            var orderDetail = await orderService.GetById(orderId);

            orderDetail.Should().NotBeNull();
        }

        [Fact]
        public void OrderServiceTests_WhenProductDeliveryTypeIsPhysical_ShouldGenerateAPackingSlipForShipping()
        {
            //Arrange

            //Act

            //Assert
        }

        [Fact]
        public void OrderServiceTests_WhenProductDeliveryTypeIsPhysical_ShouldGenerateACommissionPaymentToTheAgent()
        {
            //Arrange

            //Act

            //Assert
        }

        [Fact]
        public void OrderServiceTests_WhenProductDeliveryTypeIsNonPhysical_ShouldNotGenerateAPackingSlipForShipping()
        {
            //Arrange

            //Act

            //Assert
        }

        [Fact]
        public void OrderServiceTests_WhenProductDeliveryTypeIsNonPhysical_ShouldNotGenerateACommissionPaymentToTheAgent()
        {
            //Arrange

            //Act

            //Assert
        }

        [Fact]
        public void OrderServiceTests_WhenProductCategoryTypeIsBook_ShouldGenerateDuplicatePackingSlipForShipping()
        {
            //Arrange

            //Act

            //Assert
        }

        [Fact]
        public void OrderServiceTests_WhenProductDeliveryTypeIsNonPhysical_AndProductIsNewMembership_ShouldActivateMembership()
        {
            //Arrange

            //Act

            //Assert
        }

        [Fact]
        public void OrderServiceTests_WhenProductDeliveryTypeIsNonPhysical_AndProductIsNewMembership_ShouldNotifyToTheOwner()
        {
            //Arrange

            //Act

            //Assert
        }

        [Fact]
        public void OrderServiceTests_WhenProductDeliveryTypeIsNonPhysical_AndProductIsUpgradeExistingMembership_ShouldUpgradeMembership()
        {
            //Arrange

            //Act

            //Assert
        }

        [Fact]
        public void OrderServiceTests_WhenProductDeliveryTypeIsNonPhysical_AndProductIsUpgradeExistingMembership_ShouldNotifyToTheOwner()
        {
            //Arrange

            //Act

            //Assert
        }

        private async Task<int> CreateProduct(
            string productName,
            ProductCategoryType productCategoryType,
            ProductDeliveryType productDeliveryType)
        {
            var request = new ProductCreateModel
            {
                Name = productName,
                CategoryType = productCategoryType,
                DeliveryType = productDeliveryType
            };

            return await productService.Create(request);
        }
    }
}