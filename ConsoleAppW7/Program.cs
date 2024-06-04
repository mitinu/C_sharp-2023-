using System;

namespace ConsoleAppW7
{
    class Program
    {
        static void increment(ref int number)
        {
            number++;
        }
        static void masNull(ref int[] mas)
        {
            mas = null;
        }
        static ref int refInt(ref int number)
        {
            return ref number;
        }
        static void masWrite(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + "\t");
            }
            Console.WriteLine();
        }
        static void sizeMas<T>(ref T[] mas, int size)
        {
            T[] masCopy = new T[size];
            if (mas.Length > masCopy.Length)
            {
                Array.Copy(mas, 0, masCopy, 0, masCopy.Length);
            }
            else
            {
                Array.Copy(mas, 0, masCopy, 0, mas.Length);
            }
            mas = masCopy;
        }
        static void testRef(ref int a)
        {
            int d = a; //тип мы чет делали с переменой но тут прикол что нам не обезательно менять а
        }
        /*static void testOut0(out int a)
        {
            int d = a;// вот тут вылитает ошибка тип надо менять а 
        }*/
        static void testOut1(out int a)
        {

            //a = a + 1;//так нелзя систему не наебешь            p.s. я пытался 
            a = 1;
            int d = a;
        }
        static void testIn(in int a)
        {
            //int a = 1;//тут наабарот нельзя менять знак но перадча идет по сылке что оптимизирует програму
            int d = a;
        }
        static int testParams(int onenumber, params int[] numbers/*, int a так не получится ибо хз когда мы перестанем добовлять params*/)
        {
            int sum = onenumber;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        static void testOP(int a = 0)//OP-необезательный параметр
        {
            int d= a; 
        }
        static void Main(string[] args)
        {
            int w27a = 0;
            increment(ref w27a);
            Console.WriteLine(w27a);
            int[] w27mas = new int[] { 0 };
            ref int w27b = ref w27mas[0];
            w27b++;
            Console.WriteLine(w27mas[0]);
            masNull(ref w27mas);
            Console.WriteLine(w27mas?.Length ?? 404);
            Console.WriteLine(refInt(ref w27a));

            Console.Write("\n\n\n");

            int[] w28mas = new int[1];
            Array.Resize(ref w28mas, 2);
            masWrite(w28mas);
            sizeMas(ref w28mas, 3);
            masWrite(w28mas);
            sizeMas(ref w28mas, 2);
            masWrite(w28mas);
            char[] w28str = new char[1];
            sizeMas(ref w28str, 2);
            for (int i = 0; i < w28str.Length; i++)
            {
                w28str[i]='@';
                Console.Write(w28str[i]);
            }
            Console.WriteLine();

            Console.Write("\n\n\n");

            int w29a;
            //testRef(ref w29a);//тут так неляьзя ибо не факт что мы там чтото меняли
            testOut1(out w29a);// тут так можно ибо out мы полюбому меняем значения
            testOut1(out int w29b);//а еше можно вот так
            testIn(w29a);//тут не обезательно обозночать in
            Console.WriteLine(testParams(3, 4, 6, 6, 8, 9,1));
            testOP();
            testOP(w29a);


        }
    }
}
