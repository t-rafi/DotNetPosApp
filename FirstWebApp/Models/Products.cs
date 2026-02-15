using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebApp.Models
{
    [Table("Product")]
    public class Product
    {
        
        [Key]
        public int ProductId { get; set; }
        [Required]  
        [StringLength(50)]
        [Display(Name = "Product Name")]
        public required string ProductName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Price")]
        public required decimal SalePrice { get; set; }


        [ForeignKey("Category")] //table name in singular form and navigation property name
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public virtual required Category Category { get; set; } //virtual for lazy loading and identify navigation property
        //public string Product { get; internal set; }
    }
}
