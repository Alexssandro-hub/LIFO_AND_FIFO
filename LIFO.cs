// C# program to demonstrate
// working of LIFO
// using Stack in C#
using System;
using System.Collections.Generic;

class LIFO
{
    // Pushing element on the top of the stack
    static void stack_push(Stack<int> stack)
    {
        for (int i = 0; i < 10000000; i++)
        {
            stack.Push(i);
        }
    }

    // Popping element from the top of the stack
    static void stack_pop(Stack<int> stack)
    {
        Console.WriteLine("Pop :");

        for (int i = 0; i < 10000000; i++)
        {
            int y = (int)stack.Pop();
            Console.WriteLine(y);
        }
    }

    // Displaying element on the top of the stack
    static void stack_peek(Stack<int> stack)
    {
        int element = (int)stack.Peek();
        Console.WriteLine("Element on stack top : " + element);
    }
    

    // Driver code
    public static void Main(String[] args)
    {
        Stack<int> stack = new Stack<int>();
        
        var watch = new System.Diagnostics.Stopwatch();
        watch.Start();

        stack_push(stack);
        stack_pop(stack);
        stack_push(stack);
        stack_peek(stack);
        watch.Stop();
        Console.WriteLine($"\n Tempo de execução: {watch.ElapsedMilliseconds} ms");
    }
}