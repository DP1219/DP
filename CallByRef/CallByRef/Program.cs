using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByRef
{
    class Program
    {
        static void Display(ref int x,ref int y)
        {
            x += 5;
            y += 5;
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Before function call,Values of a & b are " + a + " " + b);
            Display(ref a,ref b);
            Console.WriteLine("After function call,Values of a & b are " + a + " " + b);
            Console.ReadKey();

        }
    }
}
