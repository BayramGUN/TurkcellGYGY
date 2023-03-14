// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Geometry geometry = new Geometry();



var optionalSquare = geometry.AlternativeGetArea(5);
var optionalTriangle = geometry.AlternativeGetArea(3, unitTwo: 2, geometricalShape: "Triangle");
Console.WriteLine(optionalTriangle);

public class Geometry
{
    // Square & Circle
    public double GetArea(double unitOne, string geometricalShape)
    {
        double result = 0;
        switch(geometricalShape)
        {
            case "Square":
                result = Math.Pow(unitOne, 2);
                break;
            case "Circle":
                result = Math.Pow(unitOne, 2) * Math.PI;
                break;
            default:
                break;
        }
        return result;
    }
    // Rectangle & Triangle
    public double AlternativeGetArea(double unitOne, double unitTwo = 1, string geometricalShape = "Square")
    {

        
        double result = 0.0;
        switch(geometricalShape)
        {
            case "Square":
                result = Math.Pow(unitOne, 2);
                break;
            case "Circle":
                result = Math.Pow(unitOne, 2) * Math.PI;
                break;
            case "Rectangle":
                result = (unitOne * unitTwo);
                break;
            case "Triangle":
                result = (unitOne * unitTwo) / 2;
                break;
            default:
                break;
        }
        return result;
    }
}