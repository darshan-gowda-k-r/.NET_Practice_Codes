using System;

namespace MyFirstConsoleApp.Practice
{
    class InputTaking
    {
        public static void Run()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine()!;  //! is used to indicate that we are sure this will not be null

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine() ?? " "); //! is used to indicate that we are sure this will not be null, but if it is null, we provide a default value (in this case, a space) to prevent an exception.

            Console.Write("Enter your height in meters: ");
            double height = double.Parse(Console.ReadLine()!);

            Console.Write("Enter your salary: ");
            decimal salary = decimal.Parse(Console.ReadLine()!);

            Console.Write("Enter your grade (A-F): ");
            char grade = char.Parse(Console.ReadLine()!);

            Console.Write("Are you a student? (true/false): ");
            bool isStudent = bool.Parse(Console.ReadLine()!);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height} m");
            Console.WriteLine($"Salary: ${salary:N2}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Student: {isStudent}");
        }
    }
}

//int age = int.Parse(Console.ReadLine());
//double height = double.Parse(Console.ReadLine());
//float weight = float.Parse(Console.ReadLine());
//bool isActive = bool.Parse(Console.ReadLine());