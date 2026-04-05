using System;

namespace MyFirstConsoleApp.Practice
{
    class DataTypes
    {
        public static void Run()
        {
            int population = 10000;
            long worldPop = 80000L;
            float height = 5.9f;
            double distance = 384400.5;
            decimal price = 19.99m;
            
            Console.WriteLine($"int population = {population:N0}");
            Console.WriteLine("Population = " + population);
            Console.WriteLine($"long worldPop = {worldPop:N0}");
            Console.WriteLine($"float height = {height}");
            Console.WriteLine($"double distance = {distance}");
            Console.WriteLine($"decimal price = {price}");  
            Console.WriteLine();

            char grade = 'A';
            string name = "John Doe";

            Console.WriteLine($"char grade = {grade}");
            Console.WriteLine($"string name = {name}");
            Console.WriteLine();

            bool isActive = true;
            bool isCompleted = false;

            Console.WriteLine($"bool isActive = {isActive}");
            Console.WriteLine($"bool isCompleted = {isCompleted}");
            Console.WriteLine();

            var number = 10;
            var text = "Hello";
            var decimal_num = 3.14;

            Console.WriteLine($"var number = {number}");
            Console.WriteLine($"var text = {text}");
            Console.WriteLine($"var decimal_num = {decimal_num}");
            Console.WriteLine();

            string numberStr = "123";
            int parsed = int.Parse(numberStr);
            Console.WriteLine($"string to int: {numberStr} becomes {parsed}");
            Console.WriteLine();

            string studentName = "Alice";
            byte studentAge = 20;
            double gpa = 3.85;
            char studentGrade = 'A';
            bool enrolled = true;

            Console.WriteLine($"Name: {studentName}");
            Console.WriteLine($"Age: {studentAge}");
            Console.WriteLine($"GPA: {gpa}");
            Console.WriteLine($"Grade: {studentGrade}");
            Console.WriteLine($"Enrolled: {enrolled}");
            Console.WriteLine();

        }
    }
}


// {
//     string name = "Alice";
//     int age = 25;
//     Console.WriteLine($"Name: {name}, Age: {age}");
//     Console.WriteLine("Name: " + name + ", Age: " + age);
//     Console.WriteLine("Name: {0}, Age: {1}", name, age);
//     // Name: Alice, Age: 25
// }