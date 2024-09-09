using System.ComponentModel.DataAnnotations;
using BlogApp.Entity;

namespace BlogApp.Models
{
    public class PostCreateViewModel 
    {   

        [Required]
        public int PostId { get; set; }

        [Required]
        [Display(Name ="Title")]
        public string? Title { get; set; }


        [Required]
        [Display(Name ="Description")]
        public string? Description { get; set; }


        [Required]
        public string? Url { get; set; }



        [Required]
        [StringLength(3000, ErrorMessage ="Max 3000 character" , MinimumLength =10)]
        [Display(Name ="Content")]
        public string? Content { get; set; }


        public bool IsActive { get; set; }

        public List<Tag> Tags { get; set; } = new();

    }
}