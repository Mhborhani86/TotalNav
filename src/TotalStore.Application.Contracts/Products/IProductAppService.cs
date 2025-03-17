using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace TotalStore.Products
{
    public interface IProductAppService : ICrudAppService<
       ProductDTO,
       Guid,
       PagedAndSortedResultRequestDto,
       CreateUpdateProductDTO>
    {
      
    }

}
