using RSMEnterpriseIntegrationsAPI.Application.DTOs;
using RSMEnterpriseIntegrationsAPI.Application.Exceptions;
using RSMEnterpriseIntegrationsAPI.Domain.Interfaces;
using RSMEnterpriseIntegrationsAPI.Domain.Models;
using RSMEnterpriseIntegrationsAPI.Infrastructure.Repositories;

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
       

        public async Task<int> CreateProductCategory(CreateProductCategoryDto productCategoryDto)
        {
            ProductCategory product = new()
            {

                Name = productCategoryDto.Name,
                ModifiedDate = productCategoryDto.ModifiedDate

            };

            return await _productCategoryService.CreateProductCategory(product);
        }

        public async Task<int> UpdateProductCategory(UpdateProductCategoryDto productCategoryDto)
        {
            if (productCategoryDto is null)
            {
                throw new BadRequestException("Department info is not valid.");
            }
            var department = await ValidateCategoryExistence(productCategoryDto.ProductCategoryID);

            department.Name = string.IsNullOrWhiteSpace(productCategoryDto.Name) ? department.Name : productCategoryDto.Name;

            return await _productCategoryService.UpdateProductCategory(department);
        }

        public Task<int> DeleteProductCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductCategory?> GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        private async Task<ProductCategory> ValidateCategoryExistence(int? id)
        {
            var existingCategory = await _productCategoryService.GetProductCategoryById(id)
                ?? throw new NotFoundException($"Category with Id: {id} was not found.");

            return existingCategory;
        }

    }
}
