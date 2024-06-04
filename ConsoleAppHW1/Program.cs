using System;

namespace ConsoleAppHW1
{
    class Program
    {
        static void printString(char symbol, uint numberOfCharacters)
        {
            for (int i = 0; i < numberOfCharacters; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
        static int indexSearch(int[] mas, int nember)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == nember)
                {
                    return i;
                }
            }
            Console.Write("ОШИБКА!!!!!\t");
            return 404;
        }
        static void masWrite(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + "\t");
            }
            Console.WriteLine();
        }
        static void sizeMas(ref int[] mas, int size)
        {
            int[] masCopy = new int[size];
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
        static void addBeginning(ref int[] mas, int nember)
        {
            int sizeMas = mas.Length + 1;
            int[] masCopy = new int[sizeMas];
            masCopy[0] = nember;
            Array.Copy(mas, 0, masCopy, 1, mas.Length);
            mas = masCopy;
        }
        static void addEnd(ref int[] mas, int nember)
        {
            int sizeMas = mas.Length + 1;
            int[] masCopy = new int[sizeMas];
            Array.Copy(mas, 0, masCopy, 0, mas.Length);
            int lastIndex = sizeMas - 1;
            masCopy[lastIndex] = nember;
            mas = masCopy;
        }
        static void addIndex(ref int[] mas, int nember, int index)
        {
            int sizeMas = mas.Length + 1;
            int[] masCopy = new int[sizeMas];
            Array.Copy(mas, 0, masCopy, 0, index);
            masCopy[index] = nember;
            Array.Copy(mas, index, masCopy, index + 1, mas.Length - index);
            mas = masCopy;
        }
        static void deleteBeginning(ref int[] mas)
        {
            int sizeMas = mas.Length - 1;
            int[] masCopy = new int[sizeMas];
            Array.Copy(mas, 1, masCopy, 0, sizeMas);
            mas = masCopy;
        }
        static void deleteEnd(ref int[] mas)
        {
            int sizeMas = mas.Length - 1;
            int[] masCopy = new int[sizeMas];
            Array.Copy(mas, 0, masCopy, 0, sizeMas);
            mas = masCopy;
        }
        static void deleteIndex(ref int[] mas, int index)
        {
            int sizeMas = mas.Length - 1;
            int[] masCopy = new int[sizeMas];
            Array.Copy(mas, 0, masCopy, 0, index);
            Array.Copy(mas, index + 1, masCopy, index, masCopy.Length - index);
            mas = masCopy;
        }
        static void Main(string[] args)
        {
            int[] hw6a = new int[5];
            Random hw6_rnd = new Random();
            for (int i = 0; i < hw6a.Length; i++)
            {
                hw6a[i] = hw6_rnd.Next(10);
                Console.WriteLine(hw6a[i]);
            }
            Console.WriteLine();
            int hw6_summa_even = 0;
            int hw6min = hw6a[0];
            for (int i = hw6a.Length; i > 0;)
            {
                Console.WriteLine(hw6a[--i]);
                if (hw6a[i] % 2 == 0)
                {
                    hw6_summa_even += hw6a[i];
                }
                if (hw6a[i] < hw6min)
                {
                    hw6min = hw6a[i];
                }
            }
            Console.WriteLine("\n" + hw6_summa_even + "\n");
            Console.WriteLine(hw6min);

            Console.Write("\n\n\n");

            printString(')', 10);
            Console.WriteLine();
            int[] hw7mas = new int[] { 1,4,5,76,132,6,9,2};
            Console.WriteLine(indexSearch(hw7mas, 0));

            Console.Write("\n\n\n");

            int[] hw8mas = new int[] { 0, 1};
            sizeMas(ref hw8mas, 3);
            masWrite(hw8mas);
            addBeginning(ref hw8mas, 2);
            masWrite(hw8mas);
            addEnd(ref hw8mas, 4);
            masWrite(hw8mas);
            addIndex(ref hw8mas, 5, 3);
            masWrite(hw8mas);
            deleteBeginning(ref hw8mas);
            masWrite(hw8mas);
            deleteEnd(ref hw8mas);
            masWrite(hw8mas);
            deleteIndex(ref hw8mas, 2);
            masWrite(hw8mas);
        }
    }
}
