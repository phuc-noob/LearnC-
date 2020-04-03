using System;

namespace Total
{
    class Program
    {
        static void Main(string[] args)
        {
            uint num;
            Console.Write("Enter your number :");
            num =uint.Parse(Console.ReadLine());

            ulong Value;
            Value = Total(num);

            Console.Write("Total of num is   : {0}\n", Value);
            Console.WriteLine("Hello World!");
        }

        static ulong Total(uint num)
        {
            ulong Result = 0;
            for(uint i=1;i <=num; i++)
            {
                Result =Result + (ulong)i;
            }
            return Result;
        }
    }
}
