namespace ConsoleAppHW2
{
    class Program
    {
        static void WriteMass(int[] mass, int i = 0)
        {
            if (i < mass.Length)
            {
                Console.WriteLine(mass[i]);
                WriteMass(mass, ++i);
            }
        }
        static int SumMass(int[] mass, int i = 0)
        {    
            if (i < mass.Length)
            {
                return mass[i] + SumMass(mass, ++i);
            }
            return 0;
        }
        static int DigitNumders(int numbers)
        {
            if (numbers < 0) 
            {
                numbers *= -1; 
            }
            if (numbers >= 10)
            {
                return DigitNumders(numbers / 10) + numbers % 10;
            }
            return numbers;
        }
        static void Main(string[] args)
        {
            int[] hw9mass = { 0, 1, 2, 3, 4, 5, 6, };
            WriteMass(hw9mass);
            Console.WriteLine(SumMass(hw9mass));
            Console.WriteLine(DigitNumders(-1111));
        }
    }
}