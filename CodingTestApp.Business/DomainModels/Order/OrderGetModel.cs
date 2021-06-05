using CodingTestApp.Business.DomainModels.Product;
using System.Collections.Generic;

namespace CodingTestApp.Business.DomainModels.Order
{
    public class OrderGetModel
    {
        public string OrderNumber { get; set; }

        public List<OrderProductGetModel> Products { get; set; }

        public class OrderProductGetModel
        {
            public string Name { get; set; }

            public ProductDeliveryType DeliveryType { get; set; }

            public ProductCategoryType CategoryType { get; set; }
        }
    }
}