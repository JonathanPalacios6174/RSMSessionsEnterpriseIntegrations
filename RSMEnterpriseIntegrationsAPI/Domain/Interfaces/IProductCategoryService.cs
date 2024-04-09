using RSMEnterpriseIntegrationsAPI.Application.DTOs;
using RSMEnterpriseIntegrationsAPI.Domain.Models;

namespace RSMEnterpriseIntegrationsAPI.Domain.Interfaces
{
    public interface IProductCategoryService
    {
        Task<IEnumerable<GetProductCategoryDto>> GetAll();
        Task<ProductCategory?> GetProductById(int id);
        Task<int> CreateProductCategory(CreateProductCategoryDto productCategoryDto);
        Task<int> UpdateProductCategory(UpdateProductCategoryDto productCategoryDto);
        Task<int> DeleteProductCategory(int id);


    }
}
