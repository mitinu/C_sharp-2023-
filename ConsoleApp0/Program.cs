using System;
using System.Globalization;        // для точки в дробной переменой


namespace ConsoleAppW0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");//вывод в консоль
            Console.Write("привет\n");// я все еще знаю паскаль и c++
            
            Console.Write("\n\n\n");
            
            byte w1a;
            //int w1a; //переменые одного имени не могут быть 
            w1a = 0;
            Console.WriteLine(w1a);
            w1a = 1;
            sbyte w1b = 2;
            short W1q, w1w;
            W1q = 3;
            w1w = 4;
            int w1s, w1z = 5;
            bool W1x = true;
            Console.WriteLine(W1x);
            W1x = false;
            char w1e = 'd';
            string w1d = "dadada";

            Console.Write("\n\n\n");

            string w2data = Console.ReadLine();
            Console.WriteLine("ты что сказал(a) '" + w2data + "'!!!");

            Console.Write("\n\n\n");

            string w3str = "1";
            int w3a = Convert.ToInt32(w3str) * 2;
            Console.WriteLine(w3str + "*2=" + w3a);
            //а теперь пиздец
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };
            string w3str0 = "1,1";
            string w3str1 = "1.1";
            double w3a0 = Convert.ToDouble(w3str0);
            Console.WriteLine(w3a0);
            double w3a1 = Convert.ToDouble(w3str1, numberFormatInfo);
            Console.WriteLine(w3a1);
            //Вот както так

            Console.Write("\n\n\n");


            string w4str = "1";
            int w4a = int.Parse(w4str);
            Console.WriteLine(w4a);
            string w4str0 = "1,1";
            string w4str1 = "1.1";
            double w4a0 = double.Parse(w4str0);
            double w4a1 = double.Parse(w4str1, numberFormatInfo);
            Console.WriteLine(w4a0);
            Console.WriteLine(w4a1);
            string w4str2 = "1adad";
            try
            {
                int w4a2 = int.Parse(w4str2);
                Console.WriteLine(w4a2);
            }
            catch (Exception)
            {
                Console.WriteLine("ошибка");
            }
            string w4str3 = "1dadasd";
            int w4a3 = 0;
            bool w4result3 = int.TryParse(w4str3, out w4a3);
            if (w4result3)
            {
                Console.WriteLine(w4a3);
            }
            else
            {
                Console.WriteLine("ошибка");
            }

            Console.Write("\n\n\n");
        }
    }
}
