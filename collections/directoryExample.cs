using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstConsoleApp.Collections
{
    class DictionaryExample
    {
        public static void Run()
        {
            Dictionary<int, string> employees = new Dictionary<int, string>();
            
            Dictionary<string, int> ages = new Dictionary<string, int>
            {
                { "Alice", 30 },
                { "Bob", 25 },
                { "Charlie", 35 }
            };
            
            employees.Add(101, "John Doe");
            employees[102] = "Jane Smith";
            
            string name = employees[101];
            
            if (employees.TryGetValue(102, out string? empName))
            {
                Console.WriteLine(empName);
            }
            
            bool hasKey = employees.ContainsKey(101);
            bool hasValue = employees.ContainsValue("John Doe");
            
            employees[101] = "John Updated";
            
            employees.Remove(101);
            employees.Clear();
            
            foreach (string key in ages.Keys)
            {
                Console.WriteLine($"Key: {key}");
            }
            
            foreach (int age in ages.Values)
            {
                Console.WriteLine($"Age: {age}");
            }
            
            foreach (KeyValuePair<string, int> kvp in ages)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            
            var over30 = ages.Where(kvp => kvp.Value > 30).ToList();
            var sorted = ages.OrderBy(kvp => kvp.Value).ToList();
            
            Dictionary<string, int> dict = new Dictionary<string, int>(500);
        }
    }
}