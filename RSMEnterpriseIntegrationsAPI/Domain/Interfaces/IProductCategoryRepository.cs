using RSMEnterpriseIntegrationsAPI.Domain.Models;

namespace RSMEnterpriseIntegrationsAPI.Domain.Interfaces
{
    public interface IProductCategoryRepository
    {
        Task<ProductCategory?> GetProductCategoryById(int id);
        Task<IEnumerable<ProductCategory>> GetAllProductCategorys();
        Task<int> CreateProductCategory(ProductCategory productCategory);
        Task<int> UpdateProductCategory(ProductCategory productCategory);
        Task<int> DeleteProductCategory(ProductCategory productCategory);
    }
}
