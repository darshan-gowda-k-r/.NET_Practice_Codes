using System;

namespace MyFirstConsoleApp.Practice
{
    class Loops
    {
        public static void Run()
        {
            for(int i = 1; i <= 5; i++)
            {
                // Console.WriteLine($"Iteration {i}");
                Console.Write($"Iterator : {i} "); //write in same line
            }
            Console.WriteLine();
  
            int count = 1;
            while(count <= 5)
            {
                Console.WriteLine($"Count: {count}");
                count++;
            }
            Console.WriteLine();

            string[] names = { "Alice", "Bob", "Charlie" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            int num = 1;
            do
            {
                Console.WriteLine($"Number: {num}");
                num++;
            } while(num <= 5);

            for (int i = 0; i < 10; i++)
            {
                if (i == 3) continue;  // Skip 3
                if (i == 7) break;     // Stop at 7
                Console.WriteLine(i);
            }
        }
    }
}