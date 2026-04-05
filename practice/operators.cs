using System;

namespace MyFirstConsoleApp.Practice
{
    class Operators
    {
        public static void Run()
        {
            
            int a = 10;
            int b = 3;

            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a * b = {a * b}");
            Console.WriteLine($"a / b = {a / b}");
            Console.WriteLine($"a % b = {a % b}");
            Console.WriteLine();

            
            int x = 5;
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"x++ = {x++}  (post-increment, x is now {x})");
            
            x = 5;
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"++x = {++x}  (pre-increment, x is now {x})");
            
            x = 5;
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"x-- = {x--}  (post-decrement, x is now {x})");
            
            x = 5;
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"--x = {--x}  (pre-decrement, x is now {x})");
            Console.WriteLine();

            
            int num1 = 10;
            int num2 = 20;

            Console.WriteLine($"num1 = {num1}, num2 = {num2}");
            Console.WriteLine($"num1 == num2 = {num1 == num2}");
            Console.WriteLine($"num1 != num2 = {num1 != num2}");
            Console.WriteLine($"num1 > num2 = {num1 > num2}");
            Console.WriteLine($"num1 < num2 = {num1 < num2}");
            Console.WriteLine($"num1 >= num2 = {num1 >= num2}");
            Console.WriteLine($"num1 <= num2 = {num1 <= num2}");
            Console.WriteLine();

            bool isAdult = true;
            bool hasLicense = true;

            Console.WriteLine($"isAdult = {isAdult}, hasLicense = {hasLicense}");
            Console.WriteLine($"isAdult && hasLicense = {isAdult && hasLicense}");
            Console.WriteLine($"isAdult || hasLicense = {isAdult || hasLicense}");
            Console.WriteLine($"!isAdult = {!isAdult}");

            hasLicense = false;
            Console.WriteLine($"\nisAdult = {isAdult}, hasLicense = {hasLicense}");
            Console.WriteLine($"isAdult && hasLicense = {isAdult && hasLicense}");
            Console.WriteLine($"isAdult || hasLicense = {isAdult || hasLicense}");
            Console.WriteLine();

            int value = 10;
            Console.WriteLine($"Initial value = {value}");

            value += 5;
            Console.WriteLine($"value += 5  →  value = {value}");

            value -= 3;
            Console.WriteLine($"value -= 3  →  value = {value}");

            value *= 2;
            Console.WriteLine($"value *= 2  →  value = {value}");

            value /= 4;
            Console.WriteLine($"value /= 4  →  value = {value}");

            value %= 5;
            Console.WriteLine($"value %= 5  →  value = {value}");
            Console.WriteLine();

            int age = 20;
            string status = (age >= 18) ? "Adult" : "Minor";
            Console.WriteLine($"age = {age}");
            Console.WriteLine($"status = (age >= 18) ? Adult : Minor = {status}");

            int score = 85;
            string grade = (score >= 90) ? "A" : (score >= 80) ? "B" : "C";
            Console.WriteLine($"\nscore = {score}");
            Console.WriteLine($"grade = {grade}");
            Console.WriteLine();

            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;
            Console.WriteLine($"firstName + lastName = {fullName}");

            string greeting = $"Hello, {fullName}!";
            Console.WriteLine($"greeting = {greeting}");
            Console.WriteLine();

            string? name1 = null;
            string name2 = "Alice";

            string displayName1 = name1 ?? "Guest";
            string displayName2 = name2 ?? "Guest";

            Console.WriteLine($"name1 = null");
            Console.WriteLine($"name1 ?? Guest = {displayName1}");
            Console.WriteLine($"\nname2 = {name2}");
            Console.WriteLine($"name2 ?? Guest = {displayName2}");
            Console.WriteLine();

            
            double price = 29.99;
            int quantity = 3;
            double total = price * quantity;
            Console.WriteLine($"Price: ${price}, Quantity: {quantity}");
            Console.WriteLine($"Total: ${total}");

            int studentAge = 16;
            bool hasPermission = false;
            bool canParticipate = (studentAge >= 18) || hasPermission;
            Console.WriteLine($"\nAge: {studentAge}, Has Permission: {hasPermission}");
            Console.WriteLine($"Can Participate: {canParticipate}");

            int test1 = 85;
            int test2 = 90;
            int test3 = 78;
            double average = (test1 + test2 + test3) / 3.0;
            Console.WriteLine($"\nTest Scores: {test1}, {test2}, {test3}");
            Console.WriteLine($"Average: {average:F2}");

            int number = 18;
            string evenOdd = (number % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine($"\nNumber: {number} is {evenOdd}");
        }
    }
}