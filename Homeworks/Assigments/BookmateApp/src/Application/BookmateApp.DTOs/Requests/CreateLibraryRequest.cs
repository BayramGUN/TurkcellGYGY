using System.ComponentModel.DataAnnotations;

namespace BookmateApp.DTOs.Requests;
/* 
 public Guid Id { get; set; }
    public IList<BooksLibrary>? BooksLibrary { get; set; } */
public class CreateLibraryRequest
{
    [Required]
    [MaxLength(100)]
    public string Title { get; set; } = "Library";
    public int Rate { get; set; }
    
}