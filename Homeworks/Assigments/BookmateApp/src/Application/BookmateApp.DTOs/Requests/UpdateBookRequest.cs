using System.ComponentModel.DataAnnotations;

namespace BookmateApp.DTOs.Requests;

public class UpdateBookRequest
{
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Book title has not be empty!")]
    [MaxLength(75, ErrorMessage = "Book title include min 75 characters")]
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public int? Rate { get; set; }
    public string? CoverImageUrl { get; set; } = "https://picsum.photos/200/300";
    public bool? IsRead { get; set; }
    public Guid AuthorId { get; set; }
    public Guid GenreId { get; set; }
}