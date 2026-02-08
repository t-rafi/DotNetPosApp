using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebApp.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public required string CategoryName { get; set; }

        public virtual IEnumerable<Products> Product { get; set; } // Navigation property for related products. IEnumerable use korchi karon ekta category te onek gulo product thakte pare, tai list er moto collection use kora hoyeche.
    }
}
