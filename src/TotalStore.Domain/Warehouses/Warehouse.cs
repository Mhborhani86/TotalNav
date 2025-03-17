using System;
using System.Collections.Generic;
using TotalStore.Products;
using Volo.Abp.Domain.Entities.Auditing;

namespace TotalStore.Warehouses
{
    public class Warehouse:AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public bool IsActive { get; set; } = true;
        //public ICollection<Product> Products { get; set; }
    }
}
