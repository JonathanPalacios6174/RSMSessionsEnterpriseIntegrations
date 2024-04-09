using RSMEnterpriseIntegrationsAPI.Application.DTOs;
using RSMEnterpriseIntegrationsAPI.Domain.Models;

namespace RSMEnterpriseIntegrationsAPI.Domain.Interfaces
{
    public interface IProductCategoryService
    {
        Task<IEnumerable<GetProductCategoryDto>> GetAll();
        Task<ProductCategory?> GetProductById(int id);
        Task<int> CreateProduct(ProductCategory productCategory);
        Task<int> UpdateProduct(ProductCategory productCategory);
        Task<int> DeleteProduct(ProductCategory productCategory);


    }
}
