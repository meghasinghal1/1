using System;

namespace CodingTestApp.DataAdapter.Entities
{
    public class BaseEntity<TKey>
    {
        public TKey Id { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
