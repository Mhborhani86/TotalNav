using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;


namespace TotalStore.Warehouses
{
    public class WarehouseAppService:
        CrudAppService<
        Warehouse,
        WarehouseDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateWarehouseDto>,
        IWarehouseAppService
    {
        public WarehouseAppService(IRepository<Warehouse, Guid> repository)
       : base(repository)
        {

        }
    }
}
