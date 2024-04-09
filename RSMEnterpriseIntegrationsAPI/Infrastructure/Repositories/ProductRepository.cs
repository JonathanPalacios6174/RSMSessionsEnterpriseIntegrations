using Microsoft.EntityFrameworkCore;
using RSMEnterpriseIntegrationsAPI.Domain.Interfaces;
using RSMEnterpriseIntegrationsAPI.Domain.Models;

namespace RSMEnterpriseIntegrationsAPI.Infrastructure.Repositories
{
    public class ProductRepository:IProductRepository
    {
        private readonly AdvWorksDbContext _dbContext;

        public ProductRepository(AdvWorksDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<int> CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _dbContext.Set<Product>()
                .AsNoTracking()
                .ToListAsync();
        }

        public Task<Product?> GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
