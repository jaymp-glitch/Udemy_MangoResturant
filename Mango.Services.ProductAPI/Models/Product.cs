using System.ComponentModel.DataAnnotations;

namespace Mango.Services.ProductAPI.Models
{
    public class Product
    {
        //prop+Tab twice to get code for property

        //Key is a data annotation to mark the product as primary key
        [Key]
        public int ProductId { get; set; }
        
        [Required] //to make sure in DB its not a nullable filed
        public string ProductName { get; set; }
        
        [Range(1,1000)]
        public double Price { get; set; }

    }
}
