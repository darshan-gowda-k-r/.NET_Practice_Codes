using System;
using System.Collections;

namespace MyFirstConsoleApp.Collections
{
    class ArrayListExample
    {
        public static void Run()
        {
            ArrayList list = new ArrayList();
            
            list.Add(1);
            list.Add("text");
            list.Add(3.14);
            list.Add(true);
            
            int? intValue = (int?)list[0];
            string? stringValue = (string?)list[1];
            Console.WriteLine(intValue);
            Console.WriteLine(stringValue);

            list.Remove("text");
            list.RemoveAt(0);
            
            bool contains = list.Contains(3.14);
            
            list.Insert(0, "new item");
            
            foreach (object item in list)
            {
                Console.WriteLine(item);
            }
            
            list.Clear();
        }
    }
}
// int? - Nullable Int -- The ? makes the type nullable, meaning it can hold either:
// a)A regular int value (like 5, 10, -3, etc.) b) null (no value)