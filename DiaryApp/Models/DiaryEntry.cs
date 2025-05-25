using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        // Properties for the DiaryEntry class
        public int Id { get; set; }

        [Required(ErrorMessage ="Please Enter a Title")]
        [StringLength(50, MinimumLength = 2,
            ErrorMessage ="The title must be between 2 and 50 Characters")]
        public required string Title { get; set; }
        [Required(ErrorMessage ="Please Enter a Description")]
        public required string Description { get; set; }
        [Required(ErrorMessage ="Please Enter the Date it was Created")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
