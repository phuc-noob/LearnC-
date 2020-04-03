using System;

namespace divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter your number :");
            num = int.Parse(Console.ReadLine());
            Console.Write("Divisor of {0} is:", num);
            enumDivisor(num);
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        static void enumDivisor(int number)
        {
            for(int i=1; i <= number; i++)
            {
                if(number % i == 0)
                {
                    Console.Write(" {0}",i);
                }
            }
            Console.WriteLine();
        }
    }
}
