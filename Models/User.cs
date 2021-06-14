using System.ComponentModel.DataAnnotations;
namespace Form_Submission.Models
{
    public class User{

        [Required]
        [MinLength(4)]
        [Display(Name = "First Name:")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(4)]
        [Display(Name = "Last Name:")]
        public string LastName { get; set; }

        [Required]
        [Range(18,150)]
        [Display(Name = "Age:")]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email:")]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        [Display(Name = "Password:")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}