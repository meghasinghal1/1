using CodingTestApp.Business.DomainModels.Product;
using CodingTestApp.Business.Services;
using Xunit;

namespace CodingTestApp.Tests
{
    public class OrderServiceTests
    {
        private readonly ProductService productService;

        public OrderServiceTests()
        {
            productService = new ProductService();
        }

        [Fact]
        public void OrderServiceTests_HappyPath_ReturnsSuccessStatus()
        {
            //Arrange
            var request = new ProductCreateModel
            {
                Name = "Product 1",
                CategoryType = ProductCategoryType.Book,
                DeliveryType = ProductDeliveryType.Physical
            };

            //Act
            await productService.Create(request);

            //Assert
        }

        [Fact]
        public void OrderServiceTests_WithNoPayment_ShouldThrowInternalError()
        {
            //Arrange

            //Act

            //Assert
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
    }
}