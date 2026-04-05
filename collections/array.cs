using System;

namespace MyFirstConsoleApp.Collections
{
    class ArrayExample
    {
        public static void Run()
        {
            int[] numbers = new int[5];
            
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;
            
            string[] fruits = { "Apple", "Banana", "Orange" };
            
            int[] scores = new int[] { 95, 87, 92, 78, 88 };
            
            int length = numbers.Length;
            
            int firstNumber = numbers[0];
            int lastNumber = numbers[numbers.Length - 1];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            
            Array.Sort(numbers); //sorts in ascending order
            Array.Reverse(numbers); //reverses the order of elements
            
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            int index = Array.IndexOf(fruits, "Banana");
            
            Array.Clear(numbers, 0, numbers.Length); //clears all elements (sets to default value) int to 0, bool to false, string to null,(Array,from,to)
            
            int[] copy = new int[5];
            Array.Copy(numbers, copy, numbers.Length);
            
            Array.Resize(ref numbers, 10); //ref numbers - The array to resize (must use ref keyword)-The new size (number of elements)
            
        }
    }
}