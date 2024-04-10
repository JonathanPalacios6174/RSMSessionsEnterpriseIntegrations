using Microsoft.EntityFrameworkCore;
using RSMEnterpriseIntegrationsAPI.Domain.Interfaces;
using RSMEnterpriseIntegrationsAPI.Domain.Models;

namespace RSMEnterpriseIntegrationsAPI.Infrastructure.Repositories
{
    public class ProductCategoryRepository:IProductCategoryRepository
    {
        private readonly AdvWorksDbContext _dbContext;

        public ProductCategoryRepository(AdvWorksDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<int> CreateProductCategory(ProductCategory productCategory)
        {

            await _dbContext.AddAsync(productCategory);
            return await _dbContext.SaveChangesAsync();
        }

        public Task<int> DeleteProductCategory(ProductCategory productCategory)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductCategory>> GetAllProductCategorys()
        {
            return await _dbContext.Set<ProductCategory>()
              .AsNoTracking()
              .ToListAsync();
        }

        public async Task<ProductCategory?> GetProductCategoryById(int? id)
        {
            return await _dbContext.ProductCategories
               .AsNoTracking()
               .FirstOrDefaultAsync(d => d.ProductCategoryID == id);
        }

        public async Task<int> UpdateProductCategory(ProductCategory productCategory)
        {
            _dbContext.Update(productCategory);

            return await _dbContext.SaveChangesAsync();
        }
    }
}
