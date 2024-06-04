using System;

namespace ConsoleAppW2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool w8a = true;
            if(w8a)
            {
                Console.WriteLine(w8a);
                w8a = false;
            }
            else
            {
                Console.WriteLine(w8a);
                w8a = true;
            }
            if (w8a)
            {
                Console.WriteLine(w8a);
                w8a = false;
            }
            else
            {
                Console.WriteLine(w8a);
                w8a = true;
            }

            Console.Write("\n\n\n");

            if (!true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            if (!false)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("folse");
            }
            if (true & false)//и
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("folse");
            }
            if (true && true) //эта быстрее и все
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("folse");
            }
            if (true | false)//или
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("folse");
            }
            if (false || false)//эта быстрей 
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("folse");
            }

            Console.Write("\n\n\n");

            int w9a = 2;
            switch (w9a)
            {
                case 0:
                    Console.WriteLine(--w9a);
                    break;
                case 1:
                case 2:
                    Console.WriteLine(w9a);
                    break;
                default:
                    Console.WriteLine(4 + 5 + 1 + 9 + 8 + 1);
                    break;
            }

            Console.Write("\n\n\n");

            int w10i = 0;
            while (w10i < 5) 
            {
                Console.WriteLine(++w10i);
            }
            Console.WriteLine(w10i);

            Console.Write("\n\n\n");

            int w11i = 0;
            do
            {
                Console.WriteLine(++w11i);
            } while (w11i < 5);
            Console.WriteLine(w11i);

            Console.Write("\n\n\n");
        }
    }
}
