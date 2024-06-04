using System;

namespace ConsoleAppHAHA
{
    class Program
    {
        static void Main(string[] args)
        {
            //ctrl+f5
            //f11
            //size=256 col=8
            int size = 10;
            int col = 1;
            int time = 1;

            int siz = size - 1;
            for (int I = 0; I < col; I++)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = size; j > i; j--)
                    {
                        Console.Write('#');
                    }
                    System.Threading.Thread.Sleep(time);
                    Console.WriteLine();
                }
                for (int i = 0; i < size; i++)
                {
                    for (int l = 0; l <= i; l++)
                    {
                        Console.Write('#');
                    }
                    System.Threading.Thread.Sleep(time);
                    Console.WriteLine();
                    for (int j = size; j > i; j--)
                    {
                        Console.Write('#');
                    }
                    System.Threading.Thread.Sleep(time);
                    Console.WriteLine();
                }
                for (int i = 0; i < size; i++)
                {
                    for (int l = 0; l <= i; l++)
                    {
                        Console.Write('#');
                    }
                    System.Threading.Thread.Sleep(time);
                    Console.WriteLine();
                }
                for (int i = 0; i < size; i++)
                {
                    for (int l = 1; l <= i; l++)
                    {
                        Console.Write(' ');
                    }
                    for (int j = size; j > i; j--)
                    {
                        Console.Write('#');
                    }
                    System.Threading.Thread.Sleep(time);
                    Console.WriteLine();
                }
                for (int i = 0; i < size; i++)
                {
                    for (int j = siz; j > i; j--)
                    {
                        Console.Write(' ');
                    }
                    for (int l = 0; l <= i; l++)
                    {
                        Console.Write('#');
                    }
                    System.Threading.Thread.Sleep(time);
                    Console.WriteLine();
                    for (int l = 1; l <= i; l++)
                    {
                        Console.Write(' ');
                    }
                    for (int j = size; j > i; j--)
                    {
                        Console.Write('#');
                    }
                    System.Threading.Thread.Sleep(time);
                    Console.WriteLine();
                }
                for (int i = 0; i < size; i++)
                {
                    for (int j = siz; j > i; j--)
                    {
                        Console.Write(' ');
                    }
                    for (int l = 0; l <= i; l++)
                    {
                        Console.Write('#');
                    }
                    System.Threading.Thread.Sleep(time);
                    Console.WriteLine();
                }
            }
        }
    }
}
