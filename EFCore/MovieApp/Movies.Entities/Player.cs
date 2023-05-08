namespace Movies.Entities;

public class Player : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? Info { get; set; }
    public ICollection<MoviesPlayer> Movies { get; set; } = new HashSet<MoviesPlayer>();
}