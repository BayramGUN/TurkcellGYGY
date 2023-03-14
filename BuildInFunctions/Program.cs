string word = "Bilgisayar";

Console.WriteLine(word.ToUpper());
Console.WriteLine(word.Substring(5));

int index = word.IndexOf('i', 2);
Console.WriteLine(index);


int startIndex = 0;
bool isFind = word.IndexOf('i', startIndex) != -1;
while(isFind) 
{
    int findingIndex = word.IndexOf('i', startIndex);
    startIndex = findingIndex + 1;

    Console.WriteLine($"{findingIndex}");
    isFind = word.IndexOf('i', startIndex) != -1;
}
