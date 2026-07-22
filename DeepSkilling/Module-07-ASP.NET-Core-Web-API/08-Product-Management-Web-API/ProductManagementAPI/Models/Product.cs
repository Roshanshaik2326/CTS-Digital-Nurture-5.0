using System.ComponentModel.DataAnnotations;

namespace ProductManagementAPI.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "";

        [Range(1,100000)]
        public decimal Price { get; set; }

        [Range(0,1000)]
        public int Quantity { get; set; }
    }
}