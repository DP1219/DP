using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static int Mul(int a, int b)
        {
            return a * b;
        }
        static int Add(int a, int b)
        {
            return a * b;
        }
        static int Sub(int a, int b)
        {
            return a * b;
        }
        static int Div(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            int a, b,c, result;
            Console.WriteLine("Enter a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number to perform Operations between 1 to 3 ");
            c = int.Parse(Console.ReadLine());
            switch(c)
            {
                case 1:
                    Console.WriteLine("You are entered for Addition");
                    Console.WriteLine("product of a and b : {0}", Add(a, b));
                    break;
                case 2:
                    Console.WriteLine("You are entered for Multiplication");
                    Console.WriteLine("product of a and b : {0}", Mul(a, b));
                    break;
                case 3:
                    Console.WriteLine("You are entered for Subtraction");
                    Console.WriteLine("product of a and b : {0}", Sub(a, b));
                    break;
                default:
                    Console.WriteLine("You are entered for Division");
                    Console.WriteLine("product of a and b : {0}", Div(a, b));
                    break;
            }
            Console.ReadKey();
        }
    }
}
