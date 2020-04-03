using System;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("Hello World!");                      // log to console and make new line
            Console.Write("hello world \n");                        // log to console and don't make new line

            Console.WriteLine("a ={0} {2} {1}", a, 10, 19);         // use {0} print value of a

            // Console.Read()


            Console.ReadKey();                                      // wait user touch enter

        }
    }
}
