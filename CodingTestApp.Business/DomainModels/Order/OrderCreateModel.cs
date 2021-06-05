using System.Collections.Generic;

namespace CodingTestApp.Business.DomainModels.Order
{
    public class OrderCreateModel
    {
        public List<Product> Products { get; set; }

        public class Product
        {
            public int Id { get; set; }
        }
    }
}