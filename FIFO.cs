using System;
using System.Collections.Generic;

public class QueueExample
{
    public static void Main(String[] args)
    {
        Queue<int> q = new Queue<int>();

        var watch = new System.Diagnostics.Stopwatch();

        watch.Start();

        //Adicionar elementos na fila
        for (int i = 0; i < 10000000; i++)
            q.Enqueue(i);

        // Display contents of the queue.
        Console.Write("Elementos da FILA-");
        foreach (int s in q) Console.Write(s + " ");

        watch.Stop();

       	Console.WriteLine($"Tempo de execução: {watch.ElapsedMilliseconds} ms");

      	int size = q.Count;
        Console.WriteLine("\nTamanho da fila -" + size);
    }

}
