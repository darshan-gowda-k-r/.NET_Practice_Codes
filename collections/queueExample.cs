using System;
using System.Collections.Generic;

namespace MyFirstConsoleApp.Collections
{
    class QueueExample
    {
        public static void Run()
        {
            Queue<string> printQueue = new Queue<string>();
            
            printQueue.Enqueue("Document1.pdf");
            printQueue.Enqueue("Document2.pdf");
            printQueue.Enqueue("Document3.pdf");
            
            string next = printQueue.Peek();
            
            string current = printQueue.Dequeue();
            Console.WriteLine($"Printing: {current}");
            
            int remaining = printQueue.Count;
            
            while (printQueue.Count > 0)
            {
                string doc = printQueue.Dequeue();
                Console.WriteLine($"Processing: {doc}");
            }
        }
    }
}