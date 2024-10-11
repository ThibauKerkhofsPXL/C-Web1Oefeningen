using System.ComponentModel.DataAnnotations.Schema;

namespace MVCSportStore.Models
{
    public class Product
    {
        public Product() { }

        public Product(string[] productDetails) 
        {
            Name = productDetails[0];
            Description = productDetails[1];    
            Category = productDetails[2];
            Price = Convert.ToDecimal(productDetails[3]);
        }
        public long ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Column(TypeName ="decimal(8,2)")]
        public decimal? Price { get; set; }
        public string? Category { get; set; }

        //Not mapped with DB
        public decimal ProductPrice => (Price == null) ? 0 : Price.Value;
        public string ProductPriceString => ProductPrice.ToString("c");
    }
}
