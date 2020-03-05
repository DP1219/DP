using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            double c;
            Console.WriteLine("Enter a and b:");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = a * b;
            Console.WriteLine("The product of {0} and {1} is : {2}", a, b, c);
            Console.ReadKey();
        }
    }
}
