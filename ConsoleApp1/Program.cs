using System;                      //пространствое имен


namespace ConsoleAppW1 //yfназвание програмы
{
    class Program //хз
    {
        static void Main(string[] args)//мейн
        {
            int w5a = 10;
            int w5b = 4;
            int w5c = w5a + w5b;
            Console.WriteLine(w5c);
            w5c = w5a - w5b;
            Console.WriteLine(w5c);
            w5c = w5a * w5b;
            Console.WriteLine(w5c);
            double w5x = (double)w5a / w5b;
            Console.WriteLine(w5x);
            w5c = w5a % w5b;
            Console.WriteLine(w5c);
            w5c = w5a + w5b * w5c;              //есть приотритет как и в матиатике 
            Console.WriteLine(w5c);

            Console.Write("\n\n\n");

            int w6a = 0;
            w6a++;
            Console.WriteLine(w6a);
            ++w6a;
            Console.WriteLine(w6a);
            w6a--;
            Console.WriteLine(w6a);
            --w6a;
            Console.WriteLine(w6a);
            Console.WriteLine(w6a++);
            Console.WriteLine(w6a);
            Console.WriteLine(++w6a);
            Console.WriteLine(w6a);

            Console.Write("\n\n\n");

            int w7a = 3, w7b = 4;
            Console.WriteLine(w7a == w7b);
            Console.WriteLine(w7a != w7b);
            Console.WriteLine(w7a > w7b);
            Console.WriteLine(w7a < w7b);
            Console.WriteLine(w7a >= w7b);
            Console.WriteLine(w7a <= w7b);
            Console.WriteLine(!(w7a == w7b));

            Console.Write("\n\n\n");
        }
    }
}
