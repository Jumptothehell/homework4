using System;
using System.Collections.Generic;

namespace homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Enter number of city :");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");

            char[] cities = new char [n];

            Console.WriteLine("Enter Cities: ");
            Console.WriteLine("**First City that enter in is the orgin city**");
            for (int i = 0; i < n; i++)
            {
                cities[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("--------------------------------------------------");

            Queue<int> queue = new Queue<int>();
            Queue<int> front = new Queue<int>();
            Queue<int> back = new Queue<int>();

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (j <= i)
                    {
                        queue.Enqueue(i);
                    }
                    foreach (int d in queue)
                    {
                        front.Enqueue(d);
                    }
                    queue.Clear();
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (i != j)
                    {
                        queue.Enqueue(j);
                    }
                    foreach (int d in queue)
                    {
                        back.Enqueue(d);
                    }
                    queue.Clear();
                }
            }

            int[,] between = new int[n, n];
            int range = front.Count;

            for (int i = 1; i <= range; i++)
            {
                int Front = front.Dequeue();
                int Back = back.Dequeue();

                between[Front, Back] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("--------------------------------------------------");

            char End;
            int end;

            Console.WriteLine("Enter a destination city:");
            End = char.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (cities[i] == End)
                {
                    end = i;
                }
            }
        }
        // ไปต่อไม่ได้ ;-;
    }
}