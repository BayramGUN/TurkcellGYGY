// See https://aka.ms/new-console-template for more information

// boxing: put a value into a box.

// everything comes from 'object'
object o = "an object";
o = 9;
o = false;
o = new Random();
object b = "an";
o = "an";
bool yaz = o.Equals(b) ? true:false;
/* if(o == b) 
    Console.WriteLine(yaz);
 */

// '==' compares to referances
// .Equals compares to values


Address addressOne = new Address() { City = "hatay" };
Address addressTwo = new Address() { City = "hatay" };
Address addressThree = addressOne; 

Console.WriteLine(addressOne.ToString());
/* 
Console.WriteLine(addressOne.Equals(addressTwo));
Console.WriteLine(addressOne == addressTwo);
Console.WriteLine(addressOne == addressThree);
Console.WriteLine(addressOne.Equals(addressThree)); */
public class Address
{
    public string City { get; set; }

    public override bool Equals(object obj)
    {
        Address? that = (Address?) obj;

        return City.Equals(that?.City);
    }
    public override string ToString()
    {
        return $"This adress at the {City}";
    }
} 
/* 
string tryingOne = "TURKCELL";
string tryingTwo = "TURKCELL";
string tryingThree = "TURKCELLx".Substring(0, 8);
object tryingFour = tryingThree;

Console.WriteLine($"deney1 == deney2: {tryingOne == tryingTwo}");
Console.WriteLine($"deney1 == deney3: {tryingOne == tryingThree}");
Console.WriteLine($"deney1.Equals(deney2): {tryingOne.Equals(tryingTwo)}");
Console.WriteLine($"deney1.Equals(deney3): {tryingOne.Equals(tryingThree)}");
Console.WriteLine($"deney1.Equals(deney4): {tryingOne.Equals(tryingFour)}");
Console.WriteLine($"deney1 {tryingOne.GetHashCode()} == deney4 {tryingFour.GetHashCode()}: {tryingOne == tryingFour}"); */