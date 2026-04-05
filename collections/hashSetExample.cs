using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstConsoleApp.Collections
{
    class HashSetExample
    {
        public static void Run()
        {
            HashSet<int> numbers = new HashSet<int>();
            HashSet<string> names = new HashSet<string> { "Alice", "Bob", "Charlie" };
            
            bool added1 = numbers.Add(5);
            bool added2 = numbers.Add(5);
            numbers.Add(10);
            numbers.Add(15);
            
            bool contains = numbers.Contains(10);
            
            List<int> listWithDuplicates = new List<int> { 1, 2, 2, 3, 3, 3, 4 };
            HashSet<int> unique = new HashSet<int>(listWithDuplicates);
            
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5, 6 };
            
            set1.UnionWith(set2);
            
            set1.IntersectWith(set2);
            
            set1.ExceptWith(set2); // Removes all elements in set2 from set1
            
            set1.SymmetricExceptWith(set2); // Keeps only elements that are in either set1 or set2, but not in both
            
            bool isSubset = set1.IsSubsetOf(set2); // Checks if all elements of set1 are in set2
            bool isSuperset = set1.IsSupersetOf(set2); // Checks if set1 contains all elements of set2
            bool overlaps = set1.Overlaps(set2); // Checks if there are any common elements at least one common element
            
            HashSet<string> uniqueVisitors = new HashSet<string>();
            uniqueVisitors.Add("user123");
            uniqueVisitors.Add("user456");
            uniqueVisitors.Add("user123");
            Console.WriteLine($"Unique visitors: {uniqueVisitors.Count}");
        }
    }
}