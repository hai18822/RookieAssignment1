using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Models
{
    public class StudentCreateModel
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
    }
}