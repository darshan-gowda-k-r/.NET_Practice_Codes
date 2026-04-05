using System;

namespace MyFirstConsoleApp.Practice
{
    class ExceptionHandling
    {
        public static void Run()
        {
                try
                {
                    Console.WriteLine("Enter a number:");
                    int num = int.Parse(Console.ReadLine()!);
                    Console.WriteLine($"You entered: {num}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    Console.WriteLine($"Error details: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An unexpected error occurred.");
                    Console.WriteLine($"Error details: {ex.Message}");
                }
        }
    }
}