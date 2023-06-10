using System.ComponentModel.DataAnnotations;

namespace BookmateApp.DTOs.Requests;
/* 
 public Guid Id { get; set; }
    public IList<BooksLibrary>? BooksLibrary { get; set; } */
public class CreateLibraryRequest
{
    [Required(ErrorMessage = "K�t�phane ismi girmelisiniz!")]
    [MaxLength(100, ErrorMessage = "K�t�phane ismi en fazla 100 karakter i�erebilir!")]
    public string Title { get; set; } = "Library";
    public int Rate { get; set; }
    
}