using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsApi.Domains
{
    [Table("Product")]
    public class Products
    {
        [Key]
        public Guid IdProduct { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        public string? Name { get; set; }

        [Column(TypeName = "DECIMAL(5,2)")]
        public decimal Price { get; set; }  
    }
}
