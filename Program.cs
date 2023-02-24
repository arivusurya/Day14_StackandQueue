using System;


namespace Datastructures{

    public class Program{

        public static void Main(string[] args)
        {
           MyQueue<int> queue = new MyQueue<int>();

           queue.Add(50);
           queue.Add(36);
           queue.Add(70);
           queue.dequeue();
           queue.Display();
        }
    }
}