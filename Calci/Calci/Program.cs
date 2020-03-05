using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calci
{
    class Program
    {
        static void Main(string[] args)
        {
            Obj1();
            Obj2();
            Console.ReadKey();



        }

        private static void Obj2()
        {
            Calculator c = new Calculator(20, 4);
            Console.WriteLine("Module 2");
            Console.WriteLine();
            Console.WriteLine("Sum is:" + c.Add(2,4));
            Console.WriteLine();
            Console.WriteLine("Difference is:" + c.Dif());
            Console.WriteLine();
            Console.WriteLine("Product is:" + c.Mul());
            Console.WriteLine();
            Console.WriteLine("Quotient is:" + c.Div());
            Console.WriteLine();
        }

        private static void Obj1()
        {
            Calculator c = new Calculator(20, 5);
            Console.WriteLine("Module 1");
            Console.WriteLine();
            Console.WriteLine("Sum is:" + c.Add(5,7));
            Console.WriteLine();
            Console.WriteLine("Difference is:" + c.Dif());
            Console.WriteLine();
            Console.WriteLine("Product is:" + c.Mul());
            Console.WriteLine();
            Console.WriteLine("Quotient is:" + c.Div());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
