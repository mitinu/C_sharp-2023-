using System;

namespace ConsoleAppW8
{
    class Program
    {
        enum digits:byte
        {
            zero,
            one,
            two
        }
        static void Main(string[] args)
        {
            int? w33a = null;
            if(w33a != null)
            {
                Console.WriteLine(w33a);
            }
            else
            {
                Console.WriteLine("Erorr404.!.");
            }

            Console.Write("\n\n\n");

            Console.WriteLine(digits.zero);
            Console.WriteLine(digits.zero.Equals);
            Console.WriteLine((byte)digits.zero);
            Console.WriteLine();
            digits w34a = digits.zero;
            Console.WriteLine(w34a);
            Console.WriteLine(w34a.Equals);
            Console.WriteLine((byte)w34a);
            Console.WriteLine();
            Console.WriteLine((digits)0);
            Console.WriteLine();
            byte w34value = 2;
            if (Enum.IsDefined(typeof(digits), w34value))
            {
                Console.WriteLine((digits)w34value);
            }
            else
            {
                Console.WriteLine("ERORR_404!!!");
            }

        }
    }
}
