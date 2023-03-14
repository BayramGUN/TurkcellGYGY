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
        if(char.IsDigit(ch)) hasDigit = true;
        else if(char.IsLetter(ch)) hasLetter = true;
        if(!char.IsLetterOrDigit(ch)) 
        {
            hasSymbol = true;
        }
        else 
            hasLetterOrDigit = true;
    }
}
else 
    Console.WriteLine("Please enter new password includes min. 6 character");

if(hasLetter && hasDigit && hasSymbol)
    Console.WriteLine("Password is strength!");
else if((hasLetter && hasDigit) || (hasSymbol && hasLetterOrDigit))
    Console.WriteLine("Password is mid!");
else if(hasLetter || hasDigit || hasSymbol)
    Console.WriteLine("Password is weak!");

