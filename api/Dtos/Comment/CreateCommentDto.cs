using System.ComponentModel.DataAnnotations;

namespace api.Dtos.Comment
{

    public class CreateCommentDto
    {
        
        [Required]
        [MinLength(5, ErrorMessage = "Title must be at least 5 characters long.")]
        [MaxLength(280, ErrorMessage = "Title must not be longer than 280 characters.")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(5, ErrorMessage = "Content must be at least 5 characters long.")]
        [MaxLength(280, ErrorMessage = "Content must not be longer than 280 characters.")]
        public string Content { get; set; } = string.Empty;
        
    }

}
