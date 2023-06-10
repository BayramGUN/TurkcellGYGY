namespace BookmateApp.Mvc.Models;

public class BookViewModel
{
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string AuthorName { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public int? Rate { get; set; }
    public string CoverImageUrl { get; set; } = "https://picsum.photos/200/300";
    public DateTime PublishDate { get; set; }

}
