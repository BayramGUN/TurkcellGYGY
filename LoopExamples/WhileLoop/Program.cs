// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter a suggest:");

bool isWin = false;

Random randomNumberGenerator = new Random();

int puzzle = randomNumberGenerator.Next(0, 100);
while(!isWin) 
{
    int suggest = Convert.ToInt16(Console.ReadLine());

    if(suggest > puzzle) 
        Console.WriteLine("Down!");

    else if(suggest < puzzle) 
        Console.WriteLine("Up!");

    else
    {
        isWin = true;
        Console.WriteLine("Congrats!");
    } 
}



int[] numbers = { 13, 46, 0, 1, 18, -9};

int index = 0;
while(index < numbers.Length) {
    Console.WriteLine(numbers[index++]);
}