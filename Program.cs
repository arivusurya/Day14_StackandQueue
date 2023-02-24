using System;


namespace Datastructures{

    public class Program{

        public static void Main(string[] args)
        {
            Mystack<int> stack = new Mystack<int>();
            stack.Push(70);
            stack.Push(37);
            stack.Push(56);
            stack.pop();
            stack.Peek();
        }
    }
}