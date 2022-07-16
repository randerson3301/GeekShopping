using System.ComponentModel.DataAnnotations;

namespace GeekShopping.ProductApi.Model
{
    public class Product: BaseEntity
    {
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        
        [Required]
        public decimal Price { get; set; }
        
        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }    

        [StringLength(int.MaxValue)]
        public string ImageUrl { get; set; }
    }
}
