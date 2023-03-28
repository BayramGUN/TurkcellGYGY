using UsingDelegate;


// Delegate: Represents a method.
List<int> numbers = new () { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Scenario-1: Filter to the even numbers with use delegate.

var helper = new FilterHelper();

// .net 1.1
var filteredOne = helper.Filter(numbers, isEven);
showNumbers(filteredOne);

// .net 2.0
var filteredTwo = helper.Filter( numbers, delegate(int n) { return n % 2 == 1; } );
showNumbers(filteredTwo);

// .net 3.5
var filteredThree = helper.Filter(numbers, p => p > 5);
showNumbers(filteredThree);

// .net 4.0
var filteredFour = helper.Filter(numbers, p => p < 5);
alternateShowNumbers(filteredFour);

void showNumbers(List<int> filtered)
{
    foreach (var item in filtered)
    {
        Console.WriteLine(item);
    }
}

void alternateShowNumbers(List<int> numbers)
{
    numbers.ForEach(n => Console.WriteLine(n));
}

bool isEven(int number)
{
    return (number % 2 is 0);
}