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
    }
}
