using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class LoginViewModel 
    {   
        [Required]
        [EmailAddress]
        [Display(Name ="E-Mail")]
        public string? Email { get; set; }

        [Required]
        [StringLength(16, ErrorMessage ="Max 10 character" , MinimumLength =8)]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        public string? Password { get; set; }
 
    }
}