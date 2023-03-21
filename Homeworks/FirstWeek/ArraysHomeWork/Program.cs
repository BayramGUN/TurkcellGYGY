
int[] numbers = { 882 ,390, 122, 4, 6, -6, 10, -11, -120, 120, 415, -220, 416, -52, -760 };

int maxValue = Int32.MinValue;

int j = 0;
while(j < numbers.Length) 
{
    if (maxValue < numbers[j]) 
        maxValue = numbers[j];
    j++;
}

Console.WriteLine($"founded {maxValue} as the greatest number of array by while loop.");

maxValue = Int32.MinValue;
for(int i = 0; i < numbers.Length; i++)
    if (maxValue < numbers[i]) maxValue = numbers[i];


Console.WriteLine($"founded {maxValue} as the greatest number of array by for loop.");


int minValue = Int32.MaxValue;

j = 0;

while(j < numbers.Length) 
{
    if (minValue > numbers[j]) minValue = numbers[j];
    j++;
}

Console.WriteLine($"founded {minValue} as the lowest number of array by while loop.");



// reset default values to for loop example
minValue = Int32.MaxValue;

for(int i = 0; i < numbers.Length; i++) 
{
    if (minValue > numbers[i]) minValue = numbers[i];
}

Console.WriteLine($"founded {minValue} as the lowest number of array by for loop.");


// sum of array elements
int sum = 0;
j = 0;
while(j < numbers.Length) sum += numbers[j++];

Console.WriteLine($"founded sum of elements of array {sum} by while loop.");


sum = 0;
for(int i = 0; i < numbers.Length; i++) sum += numbers[i];

Console.WriteLine($"founded sum of elements of array {sum} by for loop.");



Console.WriteLine();
Console.WriteLine("Unsorted array:");
PrintArray(numbers);

for(int i = 0; i < numbers.Length; i++) 
{
    for (int k = 0; k < numbers.Length - i - 1; k++)
        if(numbers[k] > numbers[k + 1]) 
        {
            int template = numbers[k];
            numbers[k] = numbers[k + 1];
            numbers[k + 1] = template;
        }
}

Console.WriteLine();
Console.WriteLine("Sorted array:");
PrintArray(numbers);


// Function to the print arrays
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) 
    {
        if(i != array.Length - 1)
            Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
}