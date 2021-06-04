using Xunit;

namespace CodingTestApp.Tests
{
    public class OrderServiceTests
    {
        [Fact]
        public void OrderServiceTests_HappyPath_ReturnsSuccessStatus()
        {
            //Arrange

            //Act

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
        public void OrderServiceTests_WhenProductTypeIsBook_ShouldGenerateDuplicatePackingSlipForShipping()
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