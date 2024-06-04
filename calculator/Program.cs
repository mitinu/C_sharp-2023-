using System;


namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
            Console.Clear();
            Console.WriteLine("введите 1 число");
            try
            {
                double hw5number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите 2 число");
                try
                {
                    int hw5number2 = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        Console.WriteLine("введите знак '-' '+' '*' '/'");
                        char hw5sign = Convert.ToChar(Console.ReadLine());
                        switch (hw5sign)
                        {
                            case '-':
                                {
                                    Console.WriteLine("выбирите выриант\n1)1 число минус 2 число\n2)2 число минус 1 число");
                                    int hw5choice = Convert.ToInt32(Console.ReadLine());
                                    if (hw5choice == 1)
                                    {
                                        Console.WriteLine("" + hw5number1 + hw5sign + hw5number2 + "=" + (hw5number1 - hw5number2));
                                    }
                                    else if (hw5choice == 2)
                                    {
                                        Console.WriteLine("" + hw5number2 + hw5sign + hw5number1 + "=" + (hw5number2 - hw5number1));
                                    }
                                    else
                                    {
                                        Console.WriteLine("ты дурак!");
                                    }
                                }
                                break;
                            case '+':
                                Console.WriteLine("" + hw5number1 + hw5sign + hw5number2 + "=" + (hw5number1 + hw5number2));
                                break;
                            case '*':
                                Console.WriteLine("" + hw5number1 + hw5sign + hw5number2 + "=" + (hw5number1 * hw5number2));
                                break;
                            case '/':
                                {
                                    Console.WriteLine("выбирите выриант\n1)1 число деленый 2 число\n2)2 число деленый 1 число");
                                    int hw5choice = Convert.ToInt32(Console.ReadLine());
                                    if (hw5choice == 1)
                                    {
                                        if (hw5number2 == 0)
                                        {
                                            Console.WriteLine("взрыв");
                                        }
                                        else
                                        {
                                            Console.WriteLine("" + hw5number1 + hw5sign + hw5number2 + "=" + (hw5number1 / hw5number2));
                                        }
                                    }
                                    else if (hw5choice == 2)
                                    {
                                        if (hw5number1 == 0)
                                        {
                                            Console.WriteLine("взрыв");
                                        }
                                        else
                                        {
                                            Console.WriteLine("" + hw5number2 + hw5sign + hw5number1 + "=" + (hw5number2 / hw5number1));
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("ты дурак!");
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("ты дурак?");
                                break;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("введите один символ!!!");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("ввод не корректный!!!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("ввод не корректный!!!");
            }
            Console.ReadLine();
            }
        }
    }
}
