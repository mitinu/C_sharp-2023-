using System;

namespace ConsoleAppW3
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.Write("\n\n\n");

            for (int i = 0; i < 10; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                Console.WriteLine(i);
                if (i == 5) 
                {
                    break;
                }
            }

            Console.Write("\n\n\n");

            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine("i:" + i + "\tj:" + j);
                }
            }

            Console.Write("\n\n\n");

            int w12a = 5;
            string w12str = w12a % 2 == 0 ? "четное" : "нечетное";
            Console.WriteLine(w12str);

            Console.Write("\n\n\n");
        }
    }
}
