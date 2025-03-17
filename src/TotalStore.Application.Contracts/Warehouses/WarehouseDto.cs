using System;
using Volo.Abp.Application.Dtos;

namespace TotalStore.Warehouses
{
    public class WarehouseDto: AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public bool IsActive { get; set; }
       // public List<ProductDTO> Products { get; set; } = new List<ProductDTO>();
    }
}
