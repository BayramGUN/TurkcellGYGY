namespace SchoolManagement.ClientModule.GetInput;

public static class GetInputWithMessage
{
    public static string GetString(this string prompt)
    {
        Console.Write(prompt);
        string? input = Convert.ToString(Console.ReadLine());
        if (input is null)
            throw new ArgumentNullException("Please enter a string value!");
        return input;
    }
    public static int GetInt(this string prompt)
    {
        Console.Write(prompt);
        int input = Convert.ToInt32(Console.ReadLine());
        return input;
    }
    public static long GetLong(this string prompt)
    {
        Console.Write(prompt);
        long input = Convert.ToInt64(Console.ReadLine());
        return input;
    }
    public static char GetChar(this string prompt)
    {
        Console.Write(prompt);
        char input;
            input = Convert.ToChar(Console.ReadLine()!.ToUpper());
        return input;
    }
}
