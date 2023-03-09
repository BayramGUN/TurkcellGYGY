/*
    terminology:

        An array working as a pencil-case.

        there are two ways to describe an array.
            1-    I know how many staff in the array but I don't that the values.
                looks like in the code: 
                    string[] books = new string[8];

            2-    I know both of them.
                looks like in the code: 
                    string[] seasons = new string[] {"winter", "spring", "summer", "autumn"};  

                    stack              heap

            seasons[0]        0   |   "winter"
            seasons[1]        1   |   "spring"
            seasons[2]        2   |   "summer"
            seasons[3]        3   |   "autumn"

*/

// example of first way 
string[] books = new string[8];


// second way
string[] seasons = new string[] {"winter", "spring", "summer", "autumn"};


// Write first index of seasons array => seasons[0]        0   |   "winter"
Console.WriteLine(seasons[0]);


// write last index of seasons array => seasons[3]        3   |   "autumn"
// Length keyword gives us that the length of arrays. It gives us 4 in the example.
Console.WriteLine(seasons[seasons.Length - 1]);



// a program convert a integer value to its pronouncation in Turkish.

try 
{
    string[] birler = {"", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz"};
    string[] onlar = {"", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan"};

    Console.WriteLine("input an integer value from 1 to 99");

    int sayi = Convert.ToInt16(Console.ReadLine());
    if(sayi > 99) 
        throw new ArgumentOutOfRangeException("your argument has to be on 1 to 99");
    else if(sayi < 0)
        throw new IndexOutOfRangeException("your argument has to be on 1 to 99");

    int onlarBasamagi = sayi / 10;
    int birlerBasamagi = sayi % 10;
    
    Console.WriteLine($"{onlar[onlarBasamagi]} {birler[birlerBasamagi]}");

}
catch (ArgumentOutOfRangeException er)
{
    Console.Write(er.Message);
}
catch (IndexOutOfRangeException er)
{
    Console.Write(er.Message);
}
