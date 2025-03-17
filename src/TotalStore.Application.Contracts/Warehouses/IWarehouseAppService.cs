using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;


namespace TotalStore.Warehouses
{
    public interface IWarehouseAppService : ICrudAppService<
       WarehouseDto,
       Guid,
       PagedAndSortedResultRequestDto,
       CreateUpdateWarehouseDto>
    {
    }
}
