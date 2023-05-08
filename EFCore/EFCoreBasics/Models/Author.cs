namespace EFCoreBasics.Models;

public class Author
{
    public int Id { get; set; }
    public string? Firstname { get; set; }
    public string? Lastame { get; set; }
    public string? Bio { get; set; }
    public List<Book>? Books { get; set; }       
}