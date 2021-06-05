using CodingTestApp.Business.DomainModels.Order;
using CodingTestApp.Business.DomainModels.Product;
using CodingTestApp.DataAdapter.Contracts;
using CodingTestApp.DataAdapter.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodingTestApp.Business.Services
{
    public class OrderService
    {
        private readonly IOrderRepository orderRepository;
        private readonly IProductRepository productRepository;
        private readonly UserIdentityModel userIdentity;

        public OrderService(
            IOrderRepository orderRepository,
            IProductRepository productRepository,
            UserIdentityModel userIdentity)
        {
            this.orderRepository = orderRepository;
            this.productRepository = productRepository;
            this.userIdentity = userIdentity;
        }

        public async Task<decimal> Create(OrderCreateModel model)
        {
            Random random = new Random();

            var order = new OrderEntity
            {
                Number = $"DUMMY-ORDER-{random.Next(100, 999)}",
                CreatedDate = DateTime.UtcNow,
                CreatedBy = userIdentity.LoggedInUserId,
                Products = new List<ProductEntity>()
            };

            foreach(var productId in model.Products)
            {
                var productEntity = await productRepository.GetById(productId);
                if (productEntity != null)
                {
                    order.Products.Add(productEntity);
                }
                else
                {
                    throw new KeyNotFoundException();
                }
            }

            var orderId = await orderRepository.Create(order);

            return orderId;
        }

        public async Task<OrderGetModel> GetById(decimal orderId)
        {
            var orderEntity = await orderRepository.GetById(orderId);

            var orderModel = new OrderGetModel
            {
                OrderNumber = orderEntity.Number,
                Products = new List<OrderGetModel.OrderProductGetModel>()
            };

            foreach (var product in orderEntity.Products)
            {
                orderModel.Products.Add(new OrderGetModel.OrderProductGetModel
                {
                    Name = product.Name,
                    CategoryType = (ProductCategoryType)product.CategoryType,
                    DeliveryType = (ProductDeliveryType)product.DeliveryType
                });
            }

            return orderModel;
        }

        public async Task UpdatePaymentInfo(decimal orderId)
        {
            Random random = new Random();

            var orderEntity = await orderRepository.GetById(orderId);

            orderEntity.PaymentTransactionNumber = $"DUMMY-PAYPAL-{random.Next(1000, 9990)}";

            await orderRepository.Update(orderEntity);
        }
    }
}