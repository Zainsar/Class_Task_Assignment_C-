// See https://aka.ms/new-console-template for more information

// Give Array
int[] arr = { 1, 3, 42, 20, 97, 65, 88, 43, 64, 20, 12, 48, 24, 38 };

// Find the sum of all the integers in the array
int sum = arr.Sum();
Console.WriteLine($"Sum of all integers: {sum}");

// Find the maximum and minimum values in the array
int max = arr.Max();
int min = arr.Min();
Console.WriteLine($"\nMaximum value: {max}");
Console.WriteLine($"\nMinimum value: {min}");

// Count the number of even and odd integers in the array
int evenCount = arr.Count(num => num % 2 == 0);
int oddCount = arr.Count(num => num % 2 != 0);
Console.WriteLine($"\nNumber of even integers: {evenCount}");
Console.WriteLine($"\nNumber of odd integers: {oddCount}");

// Calculate the average of all the integers in the array
double average = arr.Average();
Console.WriteLine($"\nAverage of all integers: {average}");

// Check if a specific integer is present in the array
int specificNumber = 20;
bool isPresent = arr.Contains(specificNumber);
Console.WriteLine($"\n{specificNumber} is present in the array: {isPresent}\n");


// Create a two-dimensional array
int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

int rows = matrix.GetLength(0);
int cols = matrix.GetLength(1);

int sumdarr = 0;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        //sum of all elements in a two-dimensional array (matrix).
        Console.WriteLine($"sum of all elements in a two-dimensional array (matrix): {sumdarr += matrix[i, j]}");
    }
}