using System;

class Program
{
    static void Main(string[] args)
    {
        HandleMultipleExceptions("5", 1);
        HandleMultipleExceptions("abc", 1);
        HandleMultipleExceptions("3", 5);
    }

    static void HandleMultipleExceptions(string inputString, int index)
    {
        int[] numbers = { 1, 2, 3 };

        try
        {
            int parsedNumber = int.Parse(inputString);

            int result = numbers[index];

            Console.WriteLine($"Result: {result}");
        }

        catch (FormatException)
        {
            Console.WriteLine("Invalid number format");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Index out of range");
        }
    } 
}