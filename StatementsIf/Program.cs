// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the username:");

string? name = string.Empty;

name = Convert.ToString(Console.ReadLine());

Console.WriteLine($"input is {name}");

if(name is null && name is "bayram") Console.WriteLine("Hos gelmissen babus");
else if(name is null && name == "mahmut") Console.WriteLine("Hos gelmissen babus");
else Console.WriteLine("Who the fuck are you?");

Console.WriteLine("Hangi aydayız?");

string? month = string.Empty;

month = Convert.ToString(Console.ReadLine());
if(month is not null) month.ToLower();
else throw new ArgumentNullException();

if(month == "mart" || month == "nisan" || month == "mayis") Console.WriteLine($"{month} ayi ilkbahar ayidir.");
else if(month == "haziran" || month == "temmuz" || month == "agustos") Console.WriteLine($"{month} ayi yaz ayidir.");
else Console.WriteLine("kista kalmissin");


Console.WriteLine("Deger gir:");
byte number = Convert.ToByte(Console.ReadLine());

string? message = (number % 2 == 0) ? "çifttir" : "tektir"; // Ternary operators.

Console.WriteLine($"deger {message}");

string? greeting = DateTime.Now.Hour <= 16 ? "Have a Good Day" : "Good Evening";
Console.WriteLine(greeting);