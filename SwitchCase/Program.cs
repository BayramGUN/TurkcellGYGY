// See https://aka.ms/new-console-template for more information

Console.WriteLine("Choise a geometric shape (square, circle, triangle)");

string? geometry = string.Empty;

geometry =  Convert.ToString(Console.ReadLine().ToLower());


switch(geometry) { // for use enums and absulute equalities 
    case "square": 
        Console.WriteLine("square root of an edge");
    break;
    case "circle": 
        Console.WriteLine("pi * (square root of radius)");
    break;
    case "triangle": 
        Console.WriteLine("(base * height) / 2");
    break;
    default: 
        Console.WriteLine("learning of the shapes");
    break;
}

/* switch (DateTime.Now.DayOfWeek)
{
    case DayOfWeek.Sunday:
    break;  
    case DayOfWeek.Monday:
    break;  
    case DayOfWeek.Tuesday:
    break;  
    case DayOfWeek.Wednesday:
    break;  
    case DayOfWeek.Friday:
    break;  
    case DayOfWeek.Saturday:
    break;  
    default:
    break;  
} */


Console.WriteLine("Choise a symbol (fly, tile, hearts, spades)");

string? symbol = Convert.ToString(Console.ReadLine().ToLower());

switch(symbol) {

    case "fly" or "spades":
        Console.WriteLine("they are black");
        break;
    case "tile":
    case "hearts":
        Console.WriteLine("they are red");
        break;
    default:
        break;

}
