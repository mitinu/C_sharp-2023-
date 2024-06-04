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
            int d = a;
        }
        static void testRecursion(int a = 0)
        {
            if(a>=0)
            {
                testRecursion(--a);
                Console.Write(++a+" ");
            }
        }
        class item
        {
            public int value {  get; set; }
            public item Classitem {  get; set; }
        }
        static void AddItem(ref item CItem, int value)
        {
            if (CItem == null)
            {
                CItem = new item();
                CItem.value = value;
            }
            else
            {
                item a = CItem.Classitem;
                AddItem(ref a, value);
                CItem.Classitem = a;
            }
        }
        static void WriteItem(item Item)
        {
            for (item i = Item; i != null; i = i.Classitem)
            {
                Console.Write(i.value);
            }
        }
        static void WriteInt(int a)
        {
            Console.WriteLine(a);
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
                w28str[i] = '@';
                Console.Write(w28str[i]);
            }
            Console.WriteLine();

            Console.Write("\n\n\n");

            int w29a;
            //testRef(ref w29a);//тут так неляьзя ибо не факт что мы там чтото меняли
            testOut1(out w29a);// тут так можно ибо out мы полюбому меняем значения
            testOut1(out int w29b);//а еше можно вот так
            testIn(w29a);//тут не обезательно обозночать in
            Console.WriteLine(testParams(3, 4, 6, 6, 8, 9, 1));
            testOP();
            testOP(w29a);

            Console.Write("\n\n\n");

            testRecursion(30);
            Console.WriteLine();
            item w30a = null;
            AddItem(ref w30a, 3);
            AddItem(ref w30a, 7);
            AddItem(ref w30a, 4);
            WriteItem(w30a);

            Console.Write("\n\n\n");

            int w31a = 5;
            byte w31b = (byte)w31a;
            double w31d = w31a;
            WriteInt((int)w31d);
            WriteInt(w31b);

            Console.Write("\n\n\n");

            byte w32a = 255; //максимальное значение 255 //минимальное значение 0
            Console.WriteLine(++w32a);
            Console.WriteLine(--w32a);
            //2 разных использование checked
            try
            {
                Console.WriteLine(checked(++w32a));//на функцию
            }
            catch(OverflowException)
            {
                Console.WriteLine("ОШИБКАААААААА!!!!!!!!404");
            }
            try
            {
                checked//на облость
                {
                    Console.WriteLine(checked(++w32a)); 
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("ОШИБКАААААААА!!!!!!!!404");
            }
            double w32b = 1.0 / 0.0;
            Console.WriteLine(w32b);
            w32b = 0.0 / 0.0;
            Console.WriteLine(w32b);
        }
    }
}
