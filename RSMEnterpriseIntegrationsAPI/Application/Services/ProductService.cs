using RSMEnterpriseIntegrationsAPI.Application.DTOs;
using RSMEnterpriseIntegrationsAPI.Domain.Interfaces;

namespace RSMEnterpriseIntegrationsAPI.Application.Services
{
    public class ProductService:IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<int> CreateProduct(CreateProductDto ProductDto)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<GetProductDto>> GetAll()
        {
            var Products = await _productRepository.GetAllProducts();

            List<GetProductDto> productsDto = [];

            foreach (var product in Products)
            {
                GetProductDto dto = new()
                {
                    Name = product.Name,
                };
                productsDto.Add(dto);
            }
            return productsDto;
        }

        public Task<GetProductDto?> GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateProduct(UpdateProductDto ProductDto)
        {
            throw new NotImplementedException();
        }
    }
}
