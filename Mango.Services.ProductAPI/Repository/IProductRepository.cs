using Mango.Services.ProductAPI.Models.Dtos;

namespace Mango.Services.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts(); 
        Task<ProductDto> GetProductById(int productId);
        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
        Task<bool> DeleteProduct(int productId);

        //we use Auto mapper to convert ProductDto to Product and vice-versa
        //Auto mapping configuration is set up in MappingConfig.cs file(custom created)
    }
}
