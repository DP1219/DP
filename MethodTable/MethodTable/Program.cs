using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 1;
            Console.WriteLine("Enter a number to print desired Table:");
            n = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine(" {0} X {1} = {2} ", n, i, n * i);
                i++;


            } while (i <= 15);
            Console.ReadKey();
        }
    }
}
