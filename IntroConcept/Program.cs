
byte x = 2;
short y = 521;

try
{
    checked
    {
        byte result = (byte) (y / x);
        Console.Write(result);
    }
}
catch (OverflowException)
{
    Console.WriteLine("toplamda byte sınırlarını aştınız");
}