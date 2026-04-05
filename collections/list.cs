using System;
using System.Collections.Generic; // for using generic collection types like List<T>, Dictionary<TKey, TValue>, etc.
using System.Linq; // for using language integrated query (LINQ) features i.e sql like queries on collections

namespace MyFirstConsoleApp.Collections
{
    class Lists
    {
        public static void Run()
        {
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Papaya");
            fruits.AddRange(new string[] { "Orange", "Grape", "Pineapple" });
            // fruits.AddRange(new[] { "Orange", "Grape", "Pineapple" });
            // fruits.AddRange(["Orange", "Grape", "Pineapple"]);   
            string firstFruit = fruits[0];
            int count = fruits.Count;
            Console.WriteLine($"Total fruits: {count}");
            Console.WriteLine($"First fruit: {firstFruit}");
            bool hasMango = fruits.Contains("Mango");
            Console.WriteLine($"Contains Mango? {hasMango}");
            string? found  = fruits.Find(f => f.Length > 5);
            Console.WriteLine($"Found fruit with length > 5: {found}");
            fruits.Insert(0, "Mango");
            fruits.Remove("Banana");
            fruits.RemoveAt(3);
            fruits.RemoveAll(f => f.EndsWith('o')); // Remove fruits that end with 'o'
            fruits.RemoveAll(f => f.StartsWith('P')); // Remove fruits that start with 'P'
            Console.WriteLine("Fruits in the list:");
            foreach (string fruit in fruits)
            {    
                Console.WriteLine(fruit);
            }   

            List<string> colors = new List<string> { "Red", "Green", "Blue" };
        }
    }
}