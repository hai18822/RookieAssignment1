using System.ComponentModel.DataAnnotations.Schema;

namespace FEcoreAssignment2.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ProductId")]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Manufacture { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}