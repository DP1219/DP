using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAdd
{
    class Program
    {
        static void add(int a,int b)
        {
            int c;
            c = a + b;
            Console.WriteLine("Sum of a and b : {0}", c);
        }
        static int Mul(int a,int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            int a, b, result1, result2;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            add(a,b);
            result1 = Mul(a,b);
            Console.WriteLine("product of a and b : {0}", result1);
            Console.ReadKey();
        }
    }
}
