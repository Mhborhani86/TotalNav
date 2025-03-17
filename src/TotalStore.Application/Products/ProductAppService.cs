using System;
using TotalStore.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace TotalStore.Products
{
    public class ProductAppService :
        CrudAppService<
        Product,
        ProductDTO,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateProductDTO>,
        IProductAppService
    {
        public ProductAppService(IRepository<Product, Guid> repository)
        : base(repository)
        {
            GetPolicyName = TotalStorePermissions.Products.Default;
            GetListPolicyName = TotalStorePermissions.Products.Default;
            CreatePolicyName = TotalStorePermissions.Products.Create;
            UpdatePolicyName = TotalStorePermissions.Products.Edit;
            DeletePolicyName = TotalStorePermissions.Products.Delete;
        }
    }
}
