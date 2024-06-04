using System;

namespace ConsoleAppNETcoreW0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] w16a = new int[] { 12, 13, 4, 3, 2, 1, 5, 6, 7, 0, 8, 9, 10, 11 };
            Console.WriteLine(w16a[^1]);
            w16a = w16a[3..^2];
            Index w16Index = ^3;
            Console.WriteLine();
            for (int i = 0; i < w16a.Length; i++) { Console.WriteLine(w16a[i]); }
            Console.WriteLine();
            Console.WriteLine($"{w16Index.Value}\t{w16Index.IsFromEnd}\t{w16a[w16Index]}");
            w16Index = new Index(2, false);
            Console.WriteLine($"{w16Index.Value}\t{w16Index.IsFromEnd}\t{w16a[w16Index]}");
            Range w16Reange = w16Index..^3;
            w16a = w16a[w16Reange];
            Console.WriteLine();
            for (int i = 0; i < w16a.Length; i++) { Console.WriteLine(w16a[i]); }
        }
    }
}
