using System;


namespace ConsoleAppHW0
{
    class Program
    {
        static void Main(string[] args)
        {

            double hw1a = 6, hw1b = 3;
            Console.WriteLine((hw1a + hw1b) / 2);

            Console.Write("\n\n\n");


            int hw2a = 0, hw2b = 10, hw2c = 3;
            Console.WriteLine(hw2a + hw2b + hw2c);
            Console.WriteLine(hw2a * hw2b * hw2c);

            Console.Write("\n\n\n");

            //$1=r68
            int hw3d = 2;
            Console.WriteLine(hw3d * 68+"р");

            Console.Write("\n\n\n");

            int hw4a = 0;
            if (0 == hw4a % 2)
            {
                Console.WriteLine("четно");
            }
            else
            {
                Console.WriteLine("не четно");
            }

            Console.Write("\n\n\n");

            int hw5a = 9, hw5b = 21;
            int hw5c = (hw5b - hw5a + 1) / 2;
            /*
            bool hw5a_bool = false, hw5b_bool = false;
            if (hw5a > 0) 
            {
                hw5a *= -1;
                hw5a_bool = true;
            }
            if (hw5b > 0)
            {
                hw5b *= -1;
                hw5b_bool = true;
            }
            */
            if (hw5a % 2 == hw5b % 2)
            {
                if (hw5a % 2 == 1)
                {
                    Console.WriteLine("четных чисел=" + hw5c);
                    Console.WriteLine("нечетных чисел=" + ++hw5c);
                    
                }
                else
                {
                    Console.WriteLine("четных чисел=" + ++hw5c);
                    Console.WriteLine("нечетных чисел=" + --hw5c);
                }
            }
            else
            {
                Console.WriteLine("четных чисел=" + hw5c);
                Console.WriteLine("нечетных чисел=" + hw5c);
            }

            Console.Write("\n");
            /*
            if (hw5a_bool == true)
            {
                hw5a *= -1;
            }
            if (hw5b_bool == true)
            {
                hw5b *= -1;
            }
            */
            uint hw5_cheeks_even = 0;
            int hw5_summa_even = 0;
            uint hw5_cheeks_not = 0;
            int hw5_summa_not = 0;
            while (hw5a <= hw5b) 
            {
                if (hw5a % 2 == 0) 
                {
                    hw5_cheeks_even++;
                    hw5_summa_even += hw5a;
                }
                else
                {
                    hw5_cheeks_not++;
                    hw5_summa_not += hw5a;
                }
                hw5a++;
            }
            Console.WriteLine("четных чисел=" + hw5_cheeks_even);
            Console.WriteLine("сумма четных=" + hw5_summa_even);
            Console.WriteLine("нечетных чисел=" + hw5_cheeks_not);
            Console.WriteLine("сумма нечетных=" + hw5_summa_not);

            Console.Write("\n\n\n");
        }
    }
}
