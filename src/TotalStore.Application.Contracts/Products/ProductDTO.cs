using System;
using Volo.Abp.Application.Dtos;


namespace TotalStore.Products
{
    public class ProductDTO: AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        //public string WarehouseName { get; set; }
    }
}
