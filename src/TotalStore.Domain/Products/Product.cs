using System;
using TotalStore.Warehouses;
using Volo.Abp.Domain.Entities.Auditing;

namespace TotalStore.Products
{
    public class Product:AuditedAggregateRoot<Guid>
    {        
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

    }
}
