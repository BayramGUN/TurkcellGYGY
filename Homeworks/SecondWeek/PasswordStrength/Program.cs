// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter your password");

string? password = Convert.ToString(Console.ReadLine());


bool hasDigit = false;
bool hasLetter = false;
bool hasSymbol = false;
bool hasLetterOrDigit = false;
if(password.Length >= 6)
{
    foreach(char ch in password) 
    {
        Console.WriteLine("dongu");
        if(char.IsDigit(ch) & !hasDigit) 
        {
            hasDigit = true;
            Console.WriteLine($"'{ch}' is a digit: {hasDigit}");
        }
        if(char.IsLetter(ch) & !hasLetter) 
        {
            hasLetter = true;
            Console.WriteLine($"'{ch}' is a letter: {hasLetter}");
        }
        if(!char.IsLetterOrDigit(ch) & !hasSymbol) 
        {
            hasSymbol = true;
            Console.WriteLine($"'{ch}' is not a letter or digit: {hasSymbol}");
        }
        else 
            hasLetterOrDigit = true;
        if(hasDigit & hasLetter & hasSymbol) break;
    
    }
}
else 
    Console.WriteLine("Please enter new password includes min. 6 character");


Console.WriteLine(hasLetterOrDigit);

if(hasLetter && hasDigit && hasSymbol)
    Console.WriteLine("Password is strength!");
else if((hasLetter && hasDigit) || (hasSymbol && hasLetterOrDigit))
    Console.WriteLine("Password is mid!");
else if(hasLetter || hasDigit || hasSymbol)
    Console.WriteLine("Password is weak!");

