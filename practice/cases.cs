using System;

namespace MyFirstConsoleApp.Practice
{
    class Cases
    {
        public static void Run()
        {
            Console.WriteLine("Enter a Character(A-F):");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();    
            switch(ch)
            {
                case 'A':
                    Console.WriteLine("You entered A");
                    break;
                case 'B':
                    Console.WriteLine("You entered B");
                    break;
                case 'C':
                    Console.WriteLine("You entered C");
                    break;
                case 'D':
                    Console.WriteLine("You entered D");
                    break;
                case 'E':
                    Console.WriteLine("You entered E");
                    break;
                case 'F':
                    Console.WriteLine("You entered F");
                    break;
                default:
                    Console.WriteLine("Invalid Character");
                    break;
            }
        }
    }
}