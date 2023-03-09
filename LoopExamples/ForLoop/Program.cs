/* int[] numbers = { 13, 46, 0, 1, 18, -9};

int length = numbers.Length;


for (int i = 0; i < length; i++)
{
    Console.WriteLine(numbers[i]);
}
 */

 string[] countries = { "Türkiye", "Germany", "Netherland", "Sweden", "Cyprus" };

 Console.WriteLine("Please enter a country:");

 string? country = Convert.ToString(Console.ReadLine()).ToLower();

 bool isFind = false;

 for (int i = 0; i < countries.Length; i++)
 {
    if(countries[i].ToLower() == country) 
    {
        isFind = true;
        break;
    }
 }

 if (isFind) Console.WriteLine("Vordır");
 else Console.WriteLine("Yogdir");