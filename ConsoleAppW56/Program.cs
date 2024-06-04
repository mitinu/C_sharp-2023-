using System;

namespace ConsoleAppW56
{
    class Program
    {
        static void returnsOne(int a)
        {
            a = 1;
        }
        static void returnsOne(int[] a)
        {
            a[0] = 1;
        }
        static void Main(string[] args)
        {
            {
                int w21a = 1;
                Console.WriteLine(w21a);
            }
            //Console.WriteLine(w21a);

            Console.Write("\n\n\n");

            int w22a = 0;
            returnsOne(w22a);
            Console.WriteLine(w22a);
            int[] w22arr = new int[] { 0 };
            returnsOne(w22arr);
            Console.WriteLine(w22arr[0]);

            Console.Write("\n\n\n");

            int[] w23arr;
            w23arr = new int[] { 0 };
            Console.WriteLine(w23arr[0]);
            w23arr = null;
            {
                int[] w23arr0 = new int[] { 1 };
                w23arr = w23arr0;
            }
            Console.WriteLine(w23arr[0]);

            Console.Write("\n\n\n");

            string w24str = null;
            Console.WriteLine(w24str ?? "404");
            w24str = "test";
            Console.WriteLine(w24str ?? "404");

            Console.Write("\n\n\n");
/*
            string w25str = null;
            Console.WriteLine(w25str ??= string.Empty);*/
        }
    } 
}
