namespace CodingTestApp.Business.DomainModels.Product
{
    public class ProductCreateModel
    {
        public string Name { get; set; }

        public ProductDeliveryType DeliveryType { get; set; }

        public ProductCategoryType CategoryType { get; set; }
    }
}