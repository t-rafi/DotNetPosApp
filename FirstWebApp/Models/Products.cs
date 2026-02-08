using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebApp.Models
{
    [Table("Product")]
    public class Products
    {
        
        [Key]
        public int ProductId { get; set; }
        public required string ProductName { get; set; }
        public required decimal SalePrice { get; set; }


        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public virtual required Category Category { get; set; }

    }
}
