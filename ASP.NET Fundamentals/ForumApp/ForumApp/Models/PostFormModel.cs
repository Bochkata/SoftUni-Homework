using System.ComponentModel.DataAnnotations;
using static ForumApp.Data.DataConstants.Posts;

namespace ForumApp.Models
{
    public class PostFormModel
    {
        [Display(Name = "Title")]
        [Required(ErrorMessage = "The field \"{0}\" is required.")]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength, ErrorMessage = "The field \"{0}\" must have between {2} and {1} symbols.")]
        public string Title { get; set; } = null!;

        [Display(Name = "Content")]
        [Required(ErrorMessage = "The field \"{0}\" is required.")]
        [StringLength(ContentMaxLength, MinimumLength = ContentMinLength, ErrorMessage = "The field \"{0}\" must have between {2} and {1} symbols.")]
        public string Content { get; set; } = null!;      
    }
}
