using System;

namespace FuncCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 5;
            Console.WriteLine("Hello World!");
            Log();

            //ref will take address memory of value used to don't need copy 
            Console.WriteLine(value);
            IncreaseValue(ref value);
            Console.WriteLine(value);

            Console.ReadKey();

        }

        static void Log()
        {
            Console.WriteLine("function static in C# .");
        }

        // ref and out in C#
        static void IncreaseValue(ref int value)
        {
            ++value;
        }
    }
}
