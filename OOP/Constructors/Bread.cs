namespace Constructors;

public class Bread
{
    public int Piece { get; set; }
    public string Species { get; set; }

    public Bread() : this(1, "Somun Eppeh")
    {
       /*  Piece = 1;
        Species = "Leaf Bread"; */
    }

    public Bread(int piece) : this(piece, "Somun Eppah")
    {
        /* Piece = piece;
        Species = "Leaf Bread"; */
    }
    public Bread(string species) : this(1, species)
    { 
        /* Piece = 1;
        Species = species; */
    }
    public Bread(int piece, string species)
    {
        Piece = piece;
        Species = species;
    }
}