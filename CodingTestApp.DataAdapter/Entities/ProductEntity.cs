namespace CodingTestApp.DataAdapter.Entities
{
    public class ProductEntity : BaseEntity
    {
        public string Name { get; set; }

        public int DeliveryType { get; set; }

        public int CategoryType { get; set; }
    }
}