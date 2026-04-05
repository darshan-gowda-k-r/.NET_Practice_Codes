using System;
using System.Collections.Generic;

namespace MyFirstConsoleApp.Collections
{
    class StackExample
    {
        public static void Run()
        {
            Stack<string> browserHistory = new Stack<string>();
            
            browserHistory.Push("google.com");
            browserHistory.Push("github.com");
            browserHistory.Push("stackoverflow.com");
            
            string current = browserHistory.Peek();
            
            string lastPage = browserHistory.Pop();
            string previous = browserHistory.Pop();
            
            Stack<string> undoStack = new Stack<string>();
            undoStack.Push("Action 1");
            undoStack.Push("Action 2");
            undoStack.Push("Action 3");
            
            if (undoStack.Count > 0)
            {
                string lastAction = undoStack.Pop();
                Console.WriteLine($"Undoing: {lastAction}");
            }
        }
    }
}