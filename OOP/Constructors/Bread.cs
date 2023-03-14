namespace Constructors;

public class Bread
{
    public int Piece { get; set; }
    public string Species { get; set; }

    public Bread() : this(1, "Somun Eppeh")
    {
        Piece = 1;
        Species = "Leaf Bread";
    }

    public Bread(int piece)
    {
        Piece = piece;
        Species = "Leaf Bread";
    }
    public Bread(string species)
    {
        Piece = 1;
        Species = species;
    }
    public Bread(int piece, string species)
    {
        Piece = piece;
        Species = species;
    }
}