using AutoMapper;
using TotalStore.Products;
using TotalStore.Warehouses;
namespace TotalStore;

public class TotalStoreApplicationAutoMapperProfile : Profile
{
    public TotalStoreApplicationAutoMapperProfile()
    {
        CreateMap<Product, ProductDTO>();
        CreateMap<CreateUpdateProductDTO, Product>();
        CreateMap<Warehouse, WarehouseDto>();
        CreateMap<CreateUpdateWarehouseDto, Warehouse>();
    }
}
