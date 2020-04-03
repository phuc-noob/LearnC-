using System;

namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int col,row;
            Console.Write("Enter a Col :");
            col = int.Parse(Console.ReadLine());
            Console.Write("Enter a row :");
            row = int.Parse(Console.ReadLine());

            Console.WriteLine("-------that is a row and col-------");
            for(int i=0;i < row; i++)
            {
                Console.Write("\t\t");
                for(int j=0;j < col; j++)
                {
                    if(j < col-1)
                    {
                        Console.Write(" *");
                    }
                    else if(j ==col-1)
                    {
                        Console.WriteLine(" *");
                    }
                }
            }
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
