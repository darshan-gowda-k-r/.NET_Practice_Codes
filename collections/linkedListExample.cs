using System;
using System.Collections.Generic;

namespace MyFirstConsoleApp.Collections
{
    class LinkedListExample
    {
        public static void Run()
        {
            LinkedList<string> playlist = new LinkedList<string>();
            
            LinkedListNode<string> node1 = playlist.AddLast("Song1.mp3"); //LinkedListNode<string> -- contains the value and reference to the next and previous nodes and data and reference to parent
            LinkedListNode<string> node2 = playlist.AddLast("Song2.mp3");
            LinkedListNode<string> node3 = playlist.AddLast("Song3.mp3");
            
            playlist.AddFirst("Intro.mp3");
            
            playlist.AddAfter(node1, "Interlude.mp3");
            playlist.AddBefore(node2, "Bonus.mp3");
            
            string? first = playlist.First?.Value;
            string? last = playlist.Last?.Value;
            
            LinkedListNode<string>? current = playlist.First; 
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next; //Next is a reference to the next node in the list, or null if it's the last node
            }
            
            current = playlist.Last;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Previous; //Previous is a reference to the previous node in the list, or null if it's the first node  
            }
            
            playlist.Remove(node2);
            playlist.RemoveFirst(); // Removes the first node in the list
            playlist.RemoveLast(); // Removes the last node in the list
        }
    }
}