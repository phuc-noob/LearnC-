using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            int hsL,Lcb;
            int phuCap;
            double TongL;

            Console.Write("Enter your id:\t\t");
            id = int.Parse(Console.ReadLine());

            Console.Write("Enter your name:\t");
            name = Console.ReadLine();

            Console.Write("Enter your hsL:\t\t");
            hsL = int.Parse(Console.ReadLine());

            Console.Write("Enter your Lcb:\t\t");
            Lcb = int.Parse(Console.ReadLine());

            Console.Write("Enter your Phucap:\t");
            phuCap = int.Parse(Console.ReadLine());

            TongL = (double)Lcb * hsL/5 + phuCap;
            Console.WriteLine("Tong luong cua ban la:\t{0:0.0000}", TongL);

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
