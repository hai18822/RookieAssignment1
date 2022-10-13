using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace D3.Models
{
    public class PersonUpdateModel
    {
        [Required, DisplayName("First Name")]
        public string? FirstName { get; set; }

        [Required, DisplayName("Last Name")]
        public string? LastName { get; set; }

        [DisplayName("Phone Numer")]
        public string? PhoneNumber { get; set; }

        [DisplayName("Birth Place")]
        public string? BirthPlace { get; set; }

        public int Index { get; set; }
    }
}