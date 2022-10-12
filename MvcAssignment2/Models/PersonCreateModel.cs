using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace MvcAssignment2.Models
{
    public class PersonCreateModel
    {
        [DisplayName("First Name")]
        [Required(ErrorMessage = "{0} is required!!!")]
        public string? FirstName { get; set; }

        [DisplayName("Last Name")]
        public string? LastName { get; set; }

        [DisplayName("Gender")]
        public string? Gender { get; set; }

        [DisplayName("Date of birth")]
        public DateTime? DateOfBirth { get; set; }

        [DisplayName("Phone Numer")]
        public string? PhoneNumber { get; set; }

        [DisplayName("Birth Place")]
        public string? BirthPlace { get; set; }
    }
}