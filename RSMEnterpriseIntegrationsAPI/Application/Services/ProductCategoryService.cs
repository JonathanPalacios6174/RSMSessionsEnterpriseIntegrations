using RSMEnterpriseIntegrationsAPI.Application.DTOs;
using RSMEnterpriseIntegrationsAPI.Domain.Interfaces;
using RSMEnterpriseIntegrationsAPI.Domain.Models;

namespace RSMEnterpriseIntegrationsAPI.Application.Services
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IProductCategoryRepository _productCategoryService;

        public ProductCategoryService(IProductCategoryRepository productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }

        public async Task<IEnumerable<GetProductCategoryDto>> GetAll()
        {
            var Products = await _productCategoryService.GetAllProductCategorys();

            List<GetProductCategoryDto> productsDto = [];

            foreach (var product in Products)
            {
                GetProductCategoryDto dto = new()
                {
                    Name = product.Name,
                };
                productsDto.Add(dto);
            }
            return productsDto;
        }
       

        public Task<int> CreateProductCategory(CreateProductCategoryDto productCategoryDto)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateProductCategory(UpdateProductCategoryDto productCategoryDto)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteProductCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductCategory?> GetProductById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
