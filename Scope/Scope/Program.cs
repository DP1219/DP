using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    class Program
    {
        static int num(ref int a)
        {
            a = a + 5;
            return a;
        }

        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine("Before call:" + a);
            Console.WriteLine("In call:" + num(ref a));
            Console.WriteLine("After call:" + a);
            Console.ReadKey();
        }
    }
}
