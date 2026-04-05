using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstConsoleApp.Collections
{
    class ListExample
    {
        public static void Run()
        {
            List<string> fruits = new List<string>();
            
            List<string> colors = new List<string> { "Red", "Blue", "Green" };
            
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.AddRange(new[] { "Orange", "Mango" });
            
            string first = fruits[0];
            int count = fruits.Count;
            
            fruits.Insert(1, "Strawberry");
            
            fruits.Remove("Banana");
            fruits.RemoveAt(0);
            fruits.RemoveAll(f => f.StartsWith("M"));
            
            bool hasOrange = fruits.Contains("Orange");
            int index = fruits.IndexOf("Apple");
            string? found = fruits.Find(f => f.Length > 5);
            List<string> longNames = fruits.FindAll(f => f.Length > 5);
            
            fruits.Sort();
            fruits.Sort((a, b) => b.CompareTo(a));
            
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            
            var filtered = fruits.Where(f => f.Contains("a")).ToList();
            var ordered = fruits.OrderByDescending(f => f.Length).ToList();
            
            List<int> numbers = new List<int>(1000);
            
            var readOnly = fruits.AsReadOnly();
            
            for (int i = fruits.Count - 1; i >= 0; i--)
            {
                if (fruits[i].Length < 5)
                {
                    fruits.RemoveAt(i);
                }
            }
        }
    }
}