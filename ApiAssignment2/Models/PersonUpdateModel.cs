using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace ApiAssignment2.Models
{
    public class PersonUpdateModel
    {
        [Required, DisplayName("First Name")]
        public string? FirstName { get; set; }

        [Required, DisplayName("Last Name")]
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }

        [DisplayName("Birth Place")]
        public string? BirthPlace { get; set; }

        public int Index { get; set; }
    }
}