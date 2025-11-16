using System.ComponentModel.DataAnnotations;

namespace ValidationAttributeASPCore.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Name is must")]
        //[StringLength(15, MinimumLength = 4, ErrorMessage ="Must be within 4 to 15 chars")]
        [MinLength(4)]
        [MaxLength(15)]
        public string Name { get; set; }

        [Required(ErrorMessage ="Email is required")]
        //[EmailAddress]
        [RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(18,150, ErrorMessage ="Value must be between 18 and 150")]
        public int? Age { get; set; }

        //[Required(ErrorMessage ="Password is required")]
        //[RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*[\\d\\W])(?!.*\\.).{8,}$")]
        //public string Password { get; set; }

        //[Required(ErrorMessage = "Password confirmation is required")]
        //[Compare("Password")]
        //[Display(Name="Confirm Password")]
        //public string ConfirmPassword { get; set; }

        //[Required(ErrorMessage ="URL is mandatory")]
        //[Url]
        //public string Url { get; set; }
    }
}
