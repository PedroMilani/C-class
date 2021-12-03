using System;
using System.Collections.Generic;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            // define a new stack
            Stack<int> stack = new Stack<int>();
            // add elements to stack using Push()
            // delete elements using Pop()

            stack.Push(5);
            Console.WriteLine("Top value of the stack is {0}", stack.Peek());
            stack.Push(1);
            Console.WriteLine("Top value of the stack is {0}", stack.Peek());
            stack.Push(2);
            Console.WriteLine("Top value of the stack is {0}", stack.Peek());

            while(stack.Count > 0)
            {
                // Pop() will return the removed element
                Console.WriteLine("The top value {0} was removed from the stack", stack.Pop());
                // print the stack count
                Console.WriteLine("Current stack count = {0}", stack.Count);
            }

            int[] numbers = new int[] { 2, 5, 1, 3, 7, 9, 3 };
            // show tis array in reverse using stacks
            Stack<int> myStack = new Stack<int>();

            Console.WriteLine("The numbers in array are: ");
            foreach(int number in numbers)
            {
                Console.Write(number + " ");
                myStack.Push(number);
            }

            Console.WriteLine("\nThe numbers in reverse are: ");
            while (myStack.Count > 0)
            {
                // Pop it and store it in a variable
                int number = myStack.Pop();
                Console.Write(number + " ");
            }

            Console.ReadKey();
        }
    }
}
