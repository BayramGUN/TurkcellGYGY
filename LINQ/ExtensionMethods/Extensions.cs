namespace ExtensionMethods;

public static class Extensions
{
    public static double GetSquare(this int value) => Math.Pow(value, 2);
    public static string MergeWords(this string value)
    {
        return value.Replace(" ", string.Empty);
    }

    public static string Class(this object vary) => $"the return type of this extension method:{vary.GetType().Name}";

    public static void PrintSombrerosProperties(this Sombreros sombre)
    {
        Console.WriteLine($"Type: {sombre.Typee}\nOrigin: {sombre.Origin}\n{sombre.Description}");
    } 
}