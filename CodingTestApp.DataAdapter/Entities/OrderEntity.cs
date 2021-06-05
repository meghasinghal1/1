using System.Collections.Generic;

namespace CodingTestApp.DataAdapter.Entities
{
    public class OrderEntity : BaseEntity<decimal>
    {
        public string Number { get; set; }

        public virtual List<ProductEntity> Products { get; set; }
    }
}