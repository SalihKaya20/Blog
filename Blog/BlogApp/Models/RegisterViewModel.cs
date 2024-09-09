using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class RegisterViewModel   
    {   

        [Required]
        [Display(Name ="Username")]
        public string? UserName { get; set; }
        

        [Required]
        [Display(Name ="Name")]
        public string? Name { get; set; }


        [Required]
        [EmailAddress]
        [Display(Name ="E-Mail")]
        public string? Email { get; set; }


        [Required]
        [StringLength(16, ErrorMessage ="Max 10 character" , MinimumLength =8)]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        public string? Password { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password),ErrorMessage ="Password do not match.")]
        [Display(Name ="Confirm Password")]
        public string? ConfirmPassword { get; set; }
 
    }
}