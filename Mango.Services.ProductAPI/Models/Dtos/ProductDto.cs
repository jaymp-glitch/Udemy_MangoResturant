using System.ComponentModel.DataAnnotations;

namespace Mango.Services.ProductAPI.Models.Dtos
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string ProductDescription { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }

        //No Data annotations unlike Product class because this is DTO and not connecting to DB
        //Uses auto mapper to convert ProductDto to Product and vice-versa
        //Auto mapping is configured in newly created file 'MappingConfig.cs'
    }
}
