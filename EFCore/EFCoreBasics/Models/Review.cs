namespace EFCoreBasics.Models;

public class Review
{
    public int Id { get; set; }
    public string Comment { get; set; } = string.Empty;
    public int BookId { get; set; }
    public Book? Book { get; set; }
    public string? VoterName { get; set; }
    
    public double? Rating { get; set; }
}