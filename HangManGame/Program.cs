// See https://aka.ms/new-console-template for more information
List<string> wordList = new List<string>() { "ayna", "armut", "goga" };
var choosedWord = getRandomWord(wordList);
showsOnScreen(choosedWord);
var puzzledWord = convertToPuzzle(choosedWord);
showsOnScreen(puzzledWord);


string getRandomWord(List<string> wordList)
{
    var index = new Random().Next(wordList.Count);
    return wordList[index];
} 

string convertToPuzzle(string word) 
{
    string puzzle = string.Empty;

    for(int i = 0; i < word.Length; i++) puzzle += "*";
    
    return puzzle;
}

void showsOnScreen(string word) 
{
    Console.WriteLine(word);
}

string getLetterFromUser() 
{
    Console.WriteLine("Enter a letter...");
    string letter = Convert.ToString(Console.ReadLine());
    return letter;
}

bool isLetterFindInWord(string word, string letter)
{
    return word.ToLower().Contains(letter.ToLower());
}

Console.WriteLine(replaceStartWithLetter(choosedWord, puzzledWord, 'a'));
char[] replaceStartWithLetter(string word, string puzzle, char letter)
{
    int startIndex = 0;
    char[] arr = puzzle.ToCharArray();
    bool isFind = word.IndexOf(letter, startIndex) != -1;
    while(isFind) 
    {
        int findingIndex = word.IndexOf(letter, startIndex);
        arr[findingIndex] = letter;
        startIndex = findingIndex + 1;
        isFind = word.IndexOf(letter, startIndex) != -1;
    }
    return arr;
}