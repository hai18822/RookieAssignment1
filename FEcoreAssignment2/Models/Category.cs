using System.ComponentModel.DataAnnotations.Schema;

namespace FEcoreAssignment2.Models
{
    public class Category
    {
        [Column("CategoryId")]
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}