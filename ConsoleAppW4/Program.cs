using System;
using System.Linq;

namespace ConsoleAppW4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] w13a = new int[5];
            w13a[0] = 23;
            int w13b = w13a[4];
            Console.WriteLine(w13a.Length);

            Console.Write("\n\n\n");

            int[] w14a = new int[4] { 0, 1, 2, 3 };
            int[] w14b = new int[] { 0, 1, 2, 3 };
            int[] w14s = new[] { 0, 1, 2, 3 };
            int[] w14d = { 0, 1, 2, 3 };
            int[] w14q = Enumerable.Repeat(1, 4).ToArray();
            for (int i = 0; i < w14q.Length; i++)
            {
                Console.WriteLine(w14q[i]);
            }
            Console.WriteLine();
            int[] w14w = Enumerable.Range(10, 4).ToArray();
            for (int i = 0; i < w14w.Length; i++)
            {
                Console.WriteLine(w14w[i]);
            }

            Console.Write("\n\n\n");

            int[] w15a = new int[] { 9, 1, 2, 3, 2 };
            Console.WriteLine(w15a.Min());
            Console.WriteLine(w15a.Max());
            Console.WriteLine(w15a.Sum());
            Console.WriteLine(w15a.First());
            Console.WriteLine(w15a.Last());
            Console.WriteLine(w15a.Where(i => i % 2 == 0).Sum());
            w15a = w15a.OrderBy(i => i).ToArray();
            w15a = w15a.OrderByDescending(i => i).ToArray();
            w15a = w15a.Distinct().ToArray();
            Array.Sort(w15a);
            Console.WriteLine();
            for (int i = 0; i < w15a.Length; i++) { Console.WriteLine(w15a[i]);}
        }
    }
}
