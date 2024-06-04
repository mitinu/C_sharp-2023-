using System;


namespace ConsoleAppW5
{
    class Program
    {
        static int sum(int number_1, int number_2)
        {
            return number_1 + number_2;
        }       
        // <summary>
        // </summary>
        // <param name="number_1"></param>
        // <param name="number_2"></param>
        // <returns></returns>
        static double sum(double number_1, double number_2)
        {
            return number_1 + number_2;
        }
        static void kek()
        {
            Console.WriteLine("kek");
        }
        static void Main(string[] args)
        {
            int[,] w17a = new int[5, 3] { { 00, 01, 02 }, { 10, 11, 12 }, { 20, 21, 22 }, { 30, 31, 32 }, { 40, 41, 42 } };
            Console.WriteLine(w17a.Length);
            Console.WriteLine(w17a.Rank + "\n");
            for (int i = 0; i < w17a.GetLength(0); i++)
            {
                for (int j = 0; j < w17a.GetLength(1); j++)
                {
                    Console.Write(w17a[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.Write("\n\n\n");

            Random rand = new Random();
            int[,] w18a = new int[5, 3];
            for (int i = 0; i < w17a.GetLength(0); i++)
            {
                for (int j = 0; j < w17a.GetLength(1); j++)
                {
                    w17a[i, j] = rand.Next(100);
                    Console.Write(w17a[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.Write("\n\n\n");

            int[][] w19a = new int[3][];
            w19a[0] = new int[4];
            w19a[1] = new int[2];
            w19a[2] = w19a[0];
            for (int i = 0; i < w19a.Length; i++)
            {
                for (int j = 0; j < w19a[i].Length; j++)
                {
                    Console.Write(w19a[i][j]+"\t");
                }
                Console.WriteLine();
            }

            Console.Write("\n\n\n");

            int w20a = 5, w20b = 4;
            Console.WriteLine(sum(w20a, w20b));
            kek();

            Console.Write("\n\n\n");

            Console.WriteLine(sum(0.1, 0.2));
        }
    }
}
