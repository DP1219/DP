using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static decimal fact(int a)
        {
           decimal c = 1;
            if(a == 0 || a == 1)
                {
                    c = 1;
                }
                else
                {
                    while (a >= 1)
                    {
                    c =  c * a;
                    a--;
                    }
                }

            return c;


        }
        static void Main(string[] args)
        {
            int a;
            decimal b;
            Console.WriteLine("Enter a number to find Factorial:");
            a = int.Parse(Console.ReadLine());
            b = fact(a);
            Console.WriteLine("Factorial of {0} : {1}", a, b);
            Console.ReadKey();
        }
    }
}
