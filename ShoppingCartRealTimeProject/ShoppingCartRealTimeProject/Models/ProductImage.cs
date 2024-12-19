using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCartRealTimeProject.Models
{
    public class ProductImage
    {

        public int ProductImageId {  get; set; }
        [Required]
        public string ImageUrl  { get; set; }
      
        public int ProductId {  get; set; }
        [ForeignKey("ProductId")]
        public Product product { get; set; }

    }
}
